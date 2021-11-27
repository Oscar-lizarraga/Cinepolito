using Datos;
using System.Data;
using System.Data.SQLite;


namespace CapaDatos
{
    public class Cine : Conexion
    {
        private int idCine;
        private string nombreCine;

        public Cine(int idCine, string nombreCine)
        {
            this.idCine = idCine;
            this.nombreCine = nombreCine;
        }

        public Cine()
        {

        }

        public int IdCine { get => idCine; set => idCine = value; }
        public string NombreCine { get => nombreCine; set => nombreCine = value; }



        #region salas
        public string AgregarSala(Sala sala)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into Sala(numeroAsientos, tipoSala) values " +
                                            "(@numeroAsientos, @tipoSala)";
                    command.Parameters.AddWithValue("@numeroAsientos", sala.NumeroAsientos);
                    command.Parameters.AddWithValue("@tipoSala", sala.GetTipoSala);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado";
                    else respuesta = "No se registro";
                }
            }
            return respuesta;
        }

        public string EditarSala(Sala sala)
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update Sala set numeroAsientos=@numeroAsientos, tipoSala=@tipoSala where idSala=@idSala";
                    command.Parameters.AddWithValue("@idSala", sala.IdSala);
                    command.Parameters.AddWithValue("@numeroAsientos", sala.NumeroAsientos);
                    command.Parameters.AddWithValue("@tipoSala", sala.GetTipoSala);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        public string EliminarSala(Sala sala)
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from Sala where idSala=@idSala";
                    command.Parameters.AddWithValue("@idSala", sala.IdSala);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        public DataTable MostrarTodasLasSalas()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from Sala";
                    command.CommandType = CommandType.Text;

                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }
        #endregion


        #region empleados
        public string AgregarEmpleado(Empleado empleado)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into Empleado(nombreEmpleado, rango, usuario, contrasena) values " +
                                            "(@nombreEmpleado, @rango, @usuario, @contrasena)";
                    command.Parameters.AddWithValue("@nombreEmpleado", empleado.NombreEmpleado);
                    command.Parameters.AddWithValue("@rango", empleado.GetRango());
                    command.Parameters.AddWithValue("@usuario", empleado.Usuario);
                    command.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado";
                    else respuesta = "No se registro";
                }
            }
            return respuesta;
        }

        public string EditarEmpleado(Empleado empleado)
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update Empleado set nombreEmpleado=@nombreEmpleado, rango=@rango, usuario=@usuario," +
                                            " contrasena=@contrasena where idEmpleado=@idEmpleado";
                    command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    command.Parameters.AddWithValue("@nombreEmpleado", empleado.NombreEmpleado);
                    command.Parameters.AddWithValue("@rango", empleado.GetRango());
                    command.Parameters.AddWithValue("@usuario", empleado.Usuario);
                    command.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        public string EliminarEmpleado(Empleado empleado)
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from Empleado where idEmpleado=@idEmpleado";
                    command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        public DataTable MostrarTodosLosEmpleados()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from Empleado";
                    command.CommandType = CommandType.Text;

                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }
        #endregion


        #region Funciones
        public string AgregarFuncion(Funcion funcion, Sala sala)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into Funcion(idSala, descripcion, duracion, genero, precioVenta, fecha) values " +
                                            "(@idSala, @descripcion, @duracion, @genero, @precioVenta, @fecha)";
                    command.Parameters.AddWithValue("@idSala", sala.IdSala);
                    command.Parameters.AddWithValue("@descripcion", funcion.Descripcion);
                    command.Parameters.AddWithValue("@duracion", funcion.Duracion);
                    command.Parameters.AddWithValue("@genero", funcion.Genero);
                    command.Parameters.AddWithValue("@precioVenta", funcion.PrecioVenta);
                    command.Parameters.AddWithValue("@fecha", funcion.GetFecha());
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado";
                    else respuesta = "No se registro";
                }
            }
            return respuesta;
        }

        public string EditarFuncion(Funcion funcion, Sala sala)
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update Funcion set idSala=@idSala, descripcion=@descripcion, duracion=@duracion, genero=@genero, precioVenta=@precioVenta, fecha=@fecha" +
                                            " where idFuncion=@idFuncion";
                    command.Parameters.AddWithValue("@idFuncion", funcion.IdFuncion);
                    command.Parameters.AddWithValue("@idSala", sala.IdSala);
                    command.Parameters.AddWithValue("@descripcion", funcion.Descripcion);
                    command.Parameters.AddWithValue("@duracion", funcion.Duracion);
                    command.Parameters.AddWithValue("@genero", funcion.Genero);
                    command.Parameters.AddWithValue("@precioVenta", funcion.PrecioVenta);
                    command.Parameters.AddWithValue("@fecha", funcion.GetFecha());
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        public string EliminarFuncion(Funcion funcion)
        {
            using (SQLiteConnection conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from Funcion where idFuncion=@idFuncion";
                    command.Parameters.AddWithValue("@idFuncion", funcion.IdFuncion);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }

        public DataTable MostrarTodasLasFunciones()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                Connection.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from Funcion";
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
