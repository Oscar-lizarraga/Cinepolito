using Datos;
using System;
using System.Data;
using System.Data.SQLite;


namespace CapaDatos
{
    public class Cine : Conexion
    {
        /// <summary>
        /// Campos de la clase
        /// </summary>
        private int idCine;
        private string nombreCine;


        /// <summary>
        /// Constructores de la clase
        /// </summary>
        /// <param name="idCine"></param>
        /// <param name="nombreCine"></param>
        public Cine(int idCine, string nombreCine)
        {
            this.idCine = idCine;
            this.nombreCine = nombreCine;
        }

        public Cine()
        {

        }


        /// <summary>
        /// Propiedades de la clase
        /// </summary>
        public int IdCine { get => idCine; set => idCine = value; }
        public string NombreCine { get => nombreCine; set => nombreCine = value; }



        #region salas
        /// <summary>
        /// Este metodo agrega una nueva sala a la BDD
        /// </summary>
        /// <param name="sala"></param>
        /// <returns></returns>
        public string AgregarSala(Sala sala)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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

        /// <summary>
        /// Este metodo edita una sala de la base de datos
        /// </summary>
        /// <param name="sala">Se requiere un parametro de tipo Sala con el idSala</param>
        /// <returns></returns>
        public string EditarSala(Sala sala)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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


        /// <summary>
        /// Este metodo elimina una sala de la BDD
        /// </summary>
        /// <param name="sala">Se quiere un parametro de tipo Sala debe tener idSala</param>
        /// <returns></returns>
        public string EliminarSala(Sala sala)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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


        /// <summary>
        /// Este metodo muestra todas las salas de la BDD
        /// </summary>
        /// <returns>Datatable</returns>
        public DataTable MostrarTodasLasSalas()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
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

        /// <summary>
        /// Este metodo agrega un nuevo empleado a la BDD
        /// </summary>
        /// <param name="empleado">El parametro empleado debe tenemos todos los campos inicializados</param>
        /// <returns></returns>
        #region empleados
        public string AgregarEmpleado(Empleado empleado)
        {
            string respuesta = string.Empty;
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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


        /// <summary>
        /// Este metodo edita un empleado de la base de datos 
        /// </summary>
        /// <param name="empleado">sSe requiere un parametro de tipo empleado con el idDmpleado</param>
        /// <returns></returns>
        public string EditarEmpleado(Empleado empleado)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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

        /// <summary>
        /// Este metodo elimina un empelado de la BDD
        /// </summary>
        /// <param name="empleado">Se requiere un paramentro de tipo empelado con el idEmpleado</param>
        /// <returns></returns>
        public string EliminarEmpleado(Empleado empleado)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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

        /// <summary>
        /// Este metodo muestra todos los Empleados de la BDD
        /// </summary>
        /// <returns>Devuelve un Datatable</returns>
        public DataTable MostrarTodosLosEmpleados()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
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

        /// <summary>
        /// Funcion que verifica la entrada al empleado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns></returns>
        public DataTable VerificarAcceso(string usuario, string contrasena)
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM Empleado WHERE usuario=@usuario and contrasena=@contrasena";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return data;
        }

        public string IngresarEmpleadoActual(Empleado empleado)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update EmpleadoActual set idEmpleado=@idEmpleado";
                    command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() == 1) return "Ingreso exitoso";
                    else return "No se registro";
                }
            }
        }


        public int ObtenerIDEmpleadoActual()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM EmpleadoActual";
                    command.CommandType = CommandType.Text;
                    SQLiteDataAdapter sQLite = new SQLiteDataAdapter(command);
                    sQLite.Fill(data);
                }
            }
            return Convert.ToInt32(data.Rows[0][0]);
        }
        #endregion


        #region Funciones
        /// <summary>
        /// Metodo que argega una nueva funcion a la BDD
        /// </summary>
        /// <param name="funcion">El parametro funcion debe contener todas las propiedades</param>
        /// <param name="sala">El paranetro sala debe contener la propiedad idSala</param>
        /// <returns></returns>
        public string AgregarFuncion(Funcion funcion, Sala sala)
        {
            string respuesta = string.Empty;
            //Usamos el using para no tener que cerrar la conexion con un finally
            using (SQLiteConnection conexion = Connection)
            {
                //Abrimos la conexion con la base de datos
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    //Al comando le asignamos la conexion previamente abierta
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

                    //Si la consulta modifico algo nos arrojara un 1, en caso contrario un 0
                    if (command.ExecuteNonQuery() == 1) respuesta = "Registro aceptado"; 
                    else respuesta = "No se registro";
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Este metodo edita una funcion de la BDD
        /// </summary>
        /// <param name="funcion">Debe tener un parametro de tipo funcion con el idFuncion</param>
        /// <param name="sala">Debe detener un parametro de tipo sala con el idSala</param>
        /// <returns></returns>
        public string EditarFuncion(Funcion funcion, Sala sala)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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

        /// <summary>
        /// Este metodo elimina una funcion de la BDD
        /// </summary>
        /// <param name="funcion">Debe contener un parametro de tipo funcion con el idFuncion</param>
        /// <returns></returns>
        public string EliminarFuncion(Funcion funcion)
        {
            using (SQLiteConnection conexion = Connection)
            {
                conexion.Open();
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


        /// <summary>
        /// Este metodo muestra todas las funciones disponibles independientemente de la fecha
        /// </summary>
        /// <returns>Devuelve un datatable</returns>
        public DataTable MostrarTodasLasFunciones()
        {
            DataTable data = new DataTable();
            using (var conexion = Connection)
            {
                conexion.Open();
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
