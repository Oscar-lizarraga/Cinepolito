using Datos;
using System;

namespace CapaDatos
{
    public class Boleto : Conexion
    {

        /// <summary>
        /// Campos de la clase
        /// </summary>
        private int idBoleto;
        private DateTime fechaVenta;


        /// <summary>
        /// Constructores de la clase
        /// </summary>
        public Boleto()
        {

        }
        public Boleto(int idBoleto, DateTime fechaVenta)
        {
            this.idBoleto = idBoleto;
            this.fechaVenta = fechaVenta;
        }

        /// <summary>
        /// Propiedades de la clase
        /// </summary>
        public int IdBoleto { get => idBoleto; set => idBoleto = value; }

        /// <summary>
        /// Metodos set que devuelve la fecha en formato datetime
        /// </summary>
        /// <param name="fecha"></param>
        public void SetFechaVenta(DateTime fecha)
        {
            this.fechaVenta = fecha;
        }

        /// <summary>
        /// Metodo get que devuelve la fecha en formato string para poder almacenarlo en la BDD
        /// </summary>
        /// <returns></returns>
        public string GetFechaVenta()
        {
            return this.fechaVenta.ToString("yyyy-MM-dd hh:mm:ss");
        }



    }
}
