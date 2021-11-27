using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Asiento
    {
        private int idAsiento;
        private int numeroAsiento;
        private int numeroFila;
        private int estado;

        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int NumeroAsiento { get => numeroAsiento; set => numeroAsiento = value; }
        public int NumeroFila { get => numeroFila; set => numeroFila = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
