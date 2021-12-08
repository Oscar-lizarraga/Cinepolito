using Datos;
using System.Data.SQLite;

namespace CapaDatos
{
    public class Sala
    {
        /// <summary>
        /// Campos de la clase sala
        /// </summary>
        private int idSala;
        private int numeroAsientos;
        private TipoSala tipoSala;


        /// <summary>
        /// Propiedades de la clase funcion
        /// </summary>
        public int IdSala { get => idSala; set => idSala = value; }
        public int NumeroAsientos { get => numeroAsientos; set => numeroAsientos = value; }

        /// <summary>
        /// Metodos set y get que devuelven el tipo de sala en un dato admisible para SQlite
        /// </summary>
        public int GetTipoSala
        {
            get
            {
                return (int)this.tipoSala;
            }
        }

        public TipoSala SetTipoSala
        {
            set
            {
                tipoSala = value;
            }
        }


    }
}
