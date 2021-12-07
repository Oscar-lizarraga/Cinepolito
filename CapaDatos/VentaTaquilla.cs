﻿using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaTaquilla : Conexion
    {
        private int idVentaBoleto;
        private int cantidadBoletos;
        private float totalVenta;
        private DateTime fechaVenta;

        public VentaTaquilla()
        {

        }

        public VentaTaquilla(int idVentaBoleto, int cantidadBoletos, float totalVenta, DateTime fechaVenta)
        {
            this.idVentaBoleto = idVentaBoleto;
            this.cantidadBoletos = cantidadBoletos;
            this.totalVenta = totalVenta;
            this.fechaVenta = fechaVenta;
        }

        public int IdVentaBoleto { get => idVentaBoleto; set => idVentaBoleto = value; }
        public int CantidadBoletos { get => cantidadBoletos; set => cantidadBoletos = value; }
        public float TotalVenta { get => totalVenta; set => totalVenta = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }


        public DataTable MostrarFuncionesPorFecha(string fechaInicial)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM Funcion WHERE fecha like @fechaInicial";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicial + "%");
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }

        public DataTable MostrarFuncionesFechaYDescripcion(string fechaInicial, string descripcion)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM Funcion WHERE fecha like @fechaInicial and descripcion=@descripcion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicial + "%");
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }

        public DataTable MostrarFuncionesFechaDescripcionHora(string fechaInicial, string descripcion, string hora)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM Funcion WHERE fecha like @fechaInicial and descripcion=@descripcion and fecha like @hora";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicial + "%");
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@hora", "%"+ hora);
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }

        public int NumeroDeAsientos(int idSala)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT numeroAsientos FROM Sala WHERE idSala = @idSala   ";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idSala", idSala);
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return Convert.ToInt32(data.Rows[0]["numeroAsientos"]);
        }

        public int NumeroDeAsientosOcupados(int idFuncion)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT sum(cantidadBoletos) FROM VentaBoleto  WHERE idFuncion = @idFuncion";
                    command.Parameters.AddWithValue("@idFuncion", idFuncion);
                    command.CommandType = CommandType.Text;
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            if (data.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }

        public string AgregarVentaBoleto(Funcion funcion, VentaTaquilla ventaTaquilla, Sala sala, Boleto boleto)
        {
            string respuesta = string.Empty;
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into VentaBoleto(idFuncion, idSala, totalVenta, cantidadBoletos, fechaVenta) values " +
                                            "(@idFuncion, @idSala, @totalVenta, @cantidadBoletos, @fechaVenta)";
                    command.Parameters.AddWithValue("@idFuncion", funcion.IdFuncion);
                    command.Parameters.AddWithValue("@idSala", sala.IdSala);
                    command.Parameters.AddWithValue("@totalVenta", ventaTaquilla.TotalVenta);
                    command.Parameters.AddWithValue("@cantidadBoletos", ventaTaquilla.CantidadBoletos);
                    command.Parameters.AddWithValue("@fechaVenta", boleto.GetFechaVenta());

                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado";
                    else respuesta = "No se registro";
                }
            }
            return respuesta;
        }


        public DataTable MostrarVentaBoleto(DateTime fechaInicial, DateTime fechaFinal)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from VentaBoleto where fechaVenta between @fechaInicial and @fechaFinal;";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicial);
                    command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }


        public DataTable MostrarVentasPorFecha(string fechaInicial, string fechaFinal)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from VentaBoleto where fechaVenta between @fechaInicial and @fechaFinal";
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
