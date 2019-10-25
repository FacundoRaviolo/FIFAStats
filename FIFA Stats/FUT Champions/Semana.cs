using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_Stats.FUT_Champions
{
    public class Semana
    {
        private int numero;
        private string fecha;
        private string rango;
        private int ganados;
        private int perdidos;
        private int jugados;
        private List<Partido> partidos;

        public int Numero { get => numero; set => numero = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Rango { get => rango; set => rango = value; }
        public int Ganados { get => ganados; set => ganados = value; }
        public int Perdidos { get => perdidos; set => perdidos = value; }
        public int Jugados { get => jugados; set => jugados = value; }
        public List<Partido> Partidos { get => partidos; set => partidos = value; }
    }
}
