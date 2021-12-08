using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class VentaDulceria : Conexion
    {
        /// <summary>
        /// Campos de la clase VentaDulceria
        /// </summary>
        private int idVenta;
        private DateTime fechaVenta;
        private float totalVenta;
        private float totalCostoProveedor;
        private int totalArticulos;
        private List<Articulo> articulos;
        private FormaPago formaPago;

        /// <summary>
        /// Constructres de la clase VentaDulceria
        /// </summary>
        public VentaDulceria()
        {

        }

        public VentaDulceria(int idVenta, DateTime fechaVenta, float totalVenta, float totalCostoProveedor, int totalArticulos, List<Articulo> articulos, FormaPago formaPago)
        {
            this.idVenta = idVenta;
            this.fechaVenta = fechaVenta;
            this.totalVenta = totalVenta;
            this.totalCostoProveedor = totalCostoProveedor;
            this.totalArticulos = totalArticulos;
            this.articulos = articulos;
            this.formaPago = formaPago;
        }


        /// <summary>
        /// Propiedades de la clase ventaDulceria
        /// </summary>
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public float TotalVenta { get => totalVenta; set => totalVenta = value; }
        public float TotalCostoProveedor { get => totalCostoProveedor; set => totalCostoProveedor = value; }
        public int TotalArticulos { get => totalArticulos; set => totalArticulos = value; }
        public List<Articulo> Articulos { get => articulos; set => articulos = value; }
        public FormaPago FormaPago { get => formaPago; set => formaPago = value; }

        public void SetFechaVenta(DateTime fecha)
        {
            this.fechaVenta = fecha;
        }
        public string GetFechaVenta()
        {
            return this.fechaVenta.ToString("yyyy-MM-dd hh:mm:ss");
        }


        /// <summary>
        /// Metodo que agrega una nueva venta de dulceria
        /// </summary>
        /// <param name="venta">el parametro de tipo ventaDulceria debe contener todas sus propiedades</param>
        /// <returns>string con mensaje de si se acpeto o no</returns>
        public string AgregarVentaDulceria(VentaDulceria venta, Empleado empleado)
        {
            string respuesta = string.Empty;
            SQLiteConnection conexion = Connection;
            conexion.Open();

            using (SQLiteCommand command = new SQLiteCommand())
            {
                command.Connection = conexion;
                command.CommandText = "insert into Venta(fechaVenta, totalVenta, totalCostoProveedor, totalArticulos, formaPago, idEmpleado) values " +
                                        "(@fechaVenta, ROUND(@totalVenta,2), ROUND(@totalCostoProveedor,2), @totalArticulos, @formaPago, @idEmpleado); " +
                                        "SELECT * FROM Venta ORDER BY idVenta DESC LIMIT 1;";
                command.Parameters.AddWithValue("@fechaVenta", venta.GetFechaVenta());
                command.Parameters.AddWithValue("@totalVenta", venta.TotalVenta);
                command.Parameters.AddWithValue("@totalCostoProveedor", venta.TotalCostoProveedor);
                command.Parameters.AddWithValue("@totalArticulos", venta.TotalArticulos);
                command.Parameters.AddWithValue("@formaPago", venta.FormaPago);
                command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                command.CommandType = CommandType.Text;

                DataTable data = new DataTable();
                SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                sQLite.Fill(data);
                venta.idVenta = Convert.ToInt32(data.Rows[0]["idVenta"]);
                respuesta = AgregarVentaArticulo(venta, ref conexion);
            }
            return respuesta;

        }

        /// <summary>
        /// Este metodo agrega a la tabla ventaArticulo el conjunto de llaves foraneas de articulo y venta a la bdd
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="connection"></param>
        /// <returns>String con mensaje de si se acepto o no</returns>
        public string AgregarVentaArticulo(VentaDulceria venta, ref SQLiteConnection connection)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = connection)
            {
                foreach (Articulo item in venta.articulos)
                {
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into VentaArticulo(idVenta, idArticulo) values " +
                                                "(@idVenta, @idArticulo)";
                        command.Parameters.AddWithValue("@idVenta", venta.idVenta);
                        command.Parameters.AddWithValue("@idArticulo", item.IdArticulo);
                        command.CommandType = CommandType.Text;
                        if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado";
                        else respuesta = "No se registro";
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Este metodo muestra todas las ventas entre fechas datas
        /// </summary>
        /// <param name="fechaInicial"></param>
        /// <param name="fechaFinal"></param>
        /// <returns>Datatable</returns>
        public DataTable MostrarVentasPorFecha(string fechaInicial, string fechaFinal)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from Venta where fechaVenta between @fechaInicial and @fechaFinal;";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicial);
                    command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }




    }
}
