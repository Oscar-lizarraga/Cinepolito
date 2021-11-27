using Datos;
using System.Data.SQLite;

namespace CapaDatos
{
    public class Sala
    {
        private int idSala;
        private int numeroAsientos;
        private TipoSala tipoSala;

        public int IdSala { get => idSala; set => idSala = value; }
        public int NumeroAsientos { get => numeroAsientos; set => numeroAsientos = value; }

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
