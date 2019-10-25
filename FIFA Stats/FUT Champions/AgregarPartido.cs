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
    public partial class AgregarPartido : Form
    {
        private Partido partido;
        public Partido Partido { get => partido; set => partido = value; }

        public AgregarPartido(int numeroPartido)
        {
            InitializeComponent();
            InicializarVentana(numeroPartido);
            txt_penalesFavor.Enabled = false;
            txt_penalesContra.Enabled = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Partido nuevoPartido = new Partido();
            nuevoPartido.Numero = int.Parse(txt_numero.Text);
            nuevoPartido.NombreRival = txt_rival.Text;
            nuevoPartido.GolesFavor = int.Parse(txt_golesFavor.Text);
            nuevoPartido.GolesContra = int.Parse(txt_golesContra.Text);
            if (nuevoPartido.GolesFavor == nuevoPartido.GolesContra)
            {
                nuevoPartido.PenalesFavor = int.Parse(txt_penalesFavor.Text);
                nuevoPartido.PenalesContra = int.Parse(txt_penalesContra.Text);
                if (nuevoPartido.PenalesFavor > nuevoPartido.PenalesContra)
                {
                    nuevoPartido.Resultado = "Victoria";
                }
                else
                {
                    nuevoPartido.Resultado = "Derrota";
                }
            }
            else
            {
                if (nuevoPartido.GolesFavor > nuevoPartido.GolesContra)
                {
                    nuevoPartido.Resultado = "Victoria";
                }
                else
                {
                    nuevoPartido.Resultado = "Derrota";
                }
            }
            if (chk_localia.Checked)
            {
                nuevoPartido.Localia = "Local";
            }
            else
            {
                nuevoPartido.Localia = "Visitante";
            }
            partido = nuevoPartido;
            this.Close();
        }

        public void InicializarVentana(int numeroPartido)
        {
            txt_numero.Text = Convert.ToString(numeroPartido);
            txt_numero.Enabled = false;
        }

        private void txt_golesContra_TextChanged(object sender, EventArgs e)
        {
            if (txt_golesContra.Text == txt_golesFavor.Text && txt_golesFavor.Text != "" && txt_golesContra.Text != "")
            {
                txt_penalesFavor.Enabled = true;
                txt_penalesContra.Enabled = true;
            }
            if (txt_golesContra.Text != txt_golesFavor.Text)
            {
                txt_penalesFavor.Enabled = false;
                txt_penalesContra.Enabled = false;

            }
        }

        private void txt_golesFavor_TextChanged(object sender, EventArgs e)
        {
            if (txt_golesContra.Text == txt_golesFavor.Text && txt_golesFavor.Text != "" && txt_golesContra.Text != "")
            {
                txt_penalesFavor.Enabled = true;
                txt_penalesContra.Enabled = true;
            }
            if (txt_golesContra.Text != txt_golesFavor.Text)
            {
                txt_penalesFavor.Enabled = false;
                txt_penalesContra.Enabled = false;

            }
        }
    }
}
