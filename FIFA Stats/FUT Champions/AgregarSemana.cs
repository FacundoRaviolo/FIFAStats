using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_Stats.FUT_Champions
{
    public partial class AgregarSemana : Form
    {
        private Semana semana;
        public Semana Semana { get => semana; set => semana = value; }

        public AgregarSemana(int numero)
        {
            InitializeComponent();
            InicializarVentana(numero);
        }

        public void InicializarVentana(int numero)
        {
            txt_numero.Text = Convert.ToString(numero);
            txt_numero.Enabled = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Semana nuevaSemana = new Semana();
            nuevaSemana.Numero = int.Parse(txt_numero.Text);
            nuevaSemana.Fecha = dt_fecha.Value.ToString("dd-MM-yyyy");
            nuevaSemana.Rango = "Por determinar";
            nuevaSemana.Ganados = 0;
            nuevaSemana.Perdidos = 0;
            nuevaSemana.Jugados = 0;
            nuevaSemana.Partidos = new List<Partido>();
            semana = nuevaSemana;
            this.Close();
        }
    }
}
