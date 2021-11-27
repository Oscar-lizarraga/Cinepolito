using Datos;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CapaDatos
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombreEmpleado;
        private Rango rango;
        private string usuario;
        private string contrasena;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int GetRango()
        {
            return (int)this.rango;
        }
        public void SetRango(Rango nivelAcceso)
        {
            this.rango = nivelAcceso;
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }









    }
}
