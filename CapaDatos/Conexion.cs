using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Datos
{
    public class Conexion
    {
        private readonly SQLiteConnection connection;   
        private string direccion = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Cinepolito";

        public Conexion()
        {
            this.connection = new SQLiteConnection("Data Source=" + direccion + "\\Cinepolito.sqlite");
            this.CarpetaBDD();
        }

        internal SQLiteConnection Connection { get => connection; }

        private void CarpetaBDD()
        {
            if (!Directory.Exists(direccion))
            {
                Directory.CreateDirectory(direccion);
                this.CrearTablaEmpleado();
                this.CrearTablaArticulo();
                this.CrearTablaFuncion();
            }
            else
            {
                return;
            }
        }

        private void CrearTablaEmpleado()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE Empleado (" +
                                                "idEmpleado INTEGER NOT NULL ," +
                                                "nombreEmpleado    TEXT NOT NULL," +
                                                "rango   INTEGER NOT NULL," +
                                                "usuario   TEXT NOT NULL UNIQUE," +
                                                "contrasena   TEXT NOT NULL," +
                                                "PRIMARY KEY(idEmpleado AUTOINCREMENT));";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }


        private void CrearTablaFuncion()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE Funcion (idFuncion INTEGER NOT NULL,"+
	                            "idSala    INTEGER NOT NULL,"+
	                            "descripcion   TEXT NOT NULL,"+
	                            "duracion  TEXT NOT NULL,"+
	                            "genero    TEXT NOT NULL,"+
	                            "precioVenta   NUMERIC NOT NULL,"+
	                            "fecha TEXT NOT NULL,"+
	                            "PRIMARY KEY(idFuncion AUTOINCREMENT)); ";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }


        private void CrearTablaArticulo()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE Articulo (idArticulo    INTEGER NOT NULL,"+
	                                            "codigo    TEXT NOT NULL UNIQUE,"+
                                                "descripcion   TEXT NOT NULL,"+
	                                            "precioProveedor   NUMERIC NOT NULL,"+
	                                            "precioVenta   NUMERIC NOT NULL,"+
	                                            "PRIMARY KEY(idArticulo AUTOINCREMENT));";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }


        private void CrearTablaSala()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE Sala (idSala    INTEGER NOT NULL,"+
	                        "numeroAsientos    INTEGER NOT NULL,"+
	                        "tipoSala  INTEGER NOT NULL,"+
	                        "PRIMARY KEY(idSala AUTOINCREMENT)); ";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }


        private void CrearTablaVenta()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE Venta (idVenta   INTEGER NOT NULL,"+
	                        "fechaVenta    TEXT NOT NULL,"+
	                        "totalVenta    NUMERIC NOT NULL,"+
	                        "totalCostoProveedor   NUMERIC NOT NULL,"+
	                        "totalArticulos    INTEGER NOT NULL,"+
	                        "formaPago INTEGER NOT NULL,"+
	                        "PRIMARY KEY(idVenta AUTOINCREMENT));";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }

        private void CrearTablaVentaArticulo()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE VentaArticulo ("+
                            "idVenta   INTEGER NOT NULL,"+
	                        "idArticulo    INTEGER NOT NULL,"+
	                        "PRIMARY KEY(idArticulo,idVenta)); ";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }

        private void CrearTablaVentaBoleto()
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "CREATE TABLE VentaBoleto ("+
    "idVentaBoleto INTEGER NOT NULL,"+
	"idFuncion INTEGER NOT NULL,"+
	"idSala    INTEGER NOT NULL,"+
	"totalVenta    NUMERIC NOT NULL,"+
	"cantidadBoletos   NUMERIC NOT NULL,"+
	"fechaVenta    TEXT NOT NULL,"+
	"formaPago INTEGER NOT NULL,"+
	"PRIMARY KEY(idVentaBoleto AUTOINCREMENT)); ";
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                }
            }
        }


        //private void CrearTabla


    }
}