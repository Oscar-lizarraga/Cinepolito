using Datos;
using System;

namespace CapaDatos
{
    public class Funcion
    {
        /// <summary>
        /// Campos de la clase funcion
        /// </summary>
        private int idFuncion;
        private string descripcion;
        private int duracion;
        private string genero;
        private float precioVenta;
        private DateTime fecha;

        /// <summary>
        /// Propiedades de la clase funcion
        /// </summary>
        public int IdFuncion { get => idFuncion; set => idFuncion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Genero { get => genero; set => genero = value; }
        public float PrecioVenta { get => precioVenta; set => precioVenta = value; }

        /// <summary>
        /// Metodos set y get que devuelven la fecha en un formato admisible para SQlite
        /// </summary>
        /// <param name="fecha"></param>
        public void SetFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }
        public string GetFecha()
        {
            return this.fecha.ToString("yyyy-MM-dd hh:mm:ss");
        }


    }

}