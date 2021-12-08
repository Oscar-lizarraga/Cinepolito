using Datos;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class Articulo : Conexion
    {

        /// <summary>
        /// Campos de la clase
        /// </summary>
        private int idArticulo;
        private string codigo;
        private string descripcion;
        private float precioProveedor;
        private float precioVenta;

        public Articulo()
        {

        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="idArticulo"></param>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precioProveedor"></param>
        /// <param name="precioVenta"></param>
        public Articulo(int idArticulo, string codigo, string descripcion, float precioProveedor, float precioVenta)
        {
            this.idArticulo = idArticulo;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioProveedor = precioProveedor;
            this.precioVenta = precioVenta;
        }


        /// <summary>
        /// Propiedades de la clase
        /// </summary>
        #region
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public float PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int IdArticulo { get => idArticulo; set => idArticulo = value; }
        #endregion


        #region Articulos
        /// <summary>
        /// Este metodo agrega un nuevo articulo a la BDD
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public string AgregarArticulo(Articulo articulo)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into Articulo(codigo, descripcion, precioProveedor, precioVenta) values " +
                                            "(UPPER(@codigo), @descripcion, ROUND(@precioProveedor,2), ROUND(@precioVenta,2))";
                    command.Parameters.AddWithValue("@codigo", articulo.Codigo);
                    command.Parameters.AddWithValue("@descripcion", articulo.Descripcion);
                    command.Parameters.AddWithValue("@precioProveedor", articulo.PrecioProveedor);
                    command.Parameters.AddWithValue("@precioVenta", articulo.PrecioVenta);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado";
                    else respuesta = "No se registro";
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Este metodo edita un articulo de la BDD
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public string EditarArticulo(Articulo articulo)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update Articulo set codigo=@codigo, descripcion=@descripcion, precioProveedor=ROUND(@precioProveedor,2)," +
                        " precioVenta=ROUND(@precioVenta,2) where idArticulo=@idArticulo";
                    command.Parameters.AddWithValue("@idArticulo", articulo.IdArticulo);
                    command.Parameters.AddWithValue("@codigo", articulo.Codigo);
                    command.Parameters.AddWithValue("@descripcion", articulo.Descripcion);
                    command.Parameters.AddWithValue("@precioProveedor", articulo.PrecioProveedor);
                    command.Parameters.AddWithValue("@precioVenta", articulo.PrecioVenta);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        
        /// <summary>
        /// Este metodo elimina un articulo de la base de datos
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public string EliminarArticulo(Articulo articulo)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from Articulo where idArticulo=@idArticulo";
                    command.Parameters.AddWithValue("@idArticulo", articulo.IdArticulo);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }


        /// <summary>
        /// Este metodo muestra todos los articulos registrados de la tabla Articulo, y devuelve un datatable
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarTodosLosArticulos()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from Articulo";
                    command.CommandType = CommandType.Text;

                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }

        /// <summary>
        /// Este metodo un articulo buscado por su codigo en un datatable
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public DataTable BuscarArticuloPorCodigo(string codigo)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from Articulo where UPPER(codigo)=UPPER(@codigo)";
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.CommandType = CommandType.Text;

                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }
        #endregion


    }
}
