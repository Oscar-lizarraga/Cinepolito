using Datos;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CapaDatos
{
    public class Empleado
    {

        /// <summary>
        /// Campos de la clase empleado
        /// </summary>
        private int idEmpleado;
        private string nombreEmpleado;
        private Rango rango;
        private string usuario;
        private string contrasena;

        /// <summary>
        /// Propiedades de la clase empleado
        /// </summary>
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        /// <summary>
        /// Metodos set y get que devuelven el rango en formato admisible para SQlite
        /// </summary>
        /// <returns></returns>
        public int GetRango()
        {
            return (int)this.rango;
        }
        public void SetRango(Rango nivelAcceso)
        {
            this.rango = nivelAcceso;
        }


    }
}
