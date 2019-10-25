using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_Stats.FUT_Champions
{
    public class Partido
    {
        private int numero;
        private string localia;
        private string nombreRival;
        private int golesFavor;
        private int golesContra;
        private int penalesFavor;
        private int penalesContra;
        private string resultado;

        public string Localia { get => localia; set => localia = value; }
        public int GolesFavor { get => golesFavor; set => golesFavor = value; }
        public int GolesContra { get => golesContra; set => golesContra = value; }
        public int PenalesFavor { get => penalesFavor; set => penalesFavor = value; }
        public int PenalesContra { get => penalesContra; set => penalesContra = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public string NombreRival { get => nombreRival; set => nombreRival = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
