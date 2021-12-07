using Datos;
using System;

namespace CapaDatos
{
    public class Boleto : Conexion
    {
        private int idBoleto;
        private DateTime fechaVenta;


        public Boleto()
        {

        }
        public Boleto(int idBoleto, DateTime fechaVenta)
        {
            this.idBoleto = idBoleto;
            this.fechaVenta = fechaVenta;
        }

        public int IdBoleto { get => idBoleto; set => idBoleto = value; }
        public void SetFechaVenta(DateTime fecha)
        {
            this.fechaVenta = fecha;
        }
        public string GetFechaVenta()
        {
            return this.fechaVenta.ToString("yyyy-MM-dd hh:mm:ss");
        }



    }
}
