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

        //private void CrearTabla


    }
}