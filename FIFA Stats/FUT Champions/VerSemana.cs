using System;
using System.IO;
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

    public partial class VerSemana : Form
    {
        private CargaDatos cargaDatos = new CargaDatos();
        private Semana semanaActual;
        private int numeroPartido = 1;

        private List<Partido> listaPartidos = new List<Partido>();
        public List<Partido> ListaPartidos { get => listaPartidos; set => listaPartidos = value; }

        public VerSemana(int numero, List<Semana> ListaSemanas)
        {
            InitializeComponent();
            dgv_partidos.EnableHeadersVisualStyles = false;
            dgv_partidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_partidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 76, 122);
            dgv_partidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_partidos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_partidos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_partidos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_partidos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_partidos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_partidos.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            InicializarVentana(numero);
            foreach (Semana sem in ListaSemanas)
            {
                if (sem.Numero == numero)
                {
                    semanaActual = sem;
                    foreach (Partido par in semanaActual.Partidos)
                    {
                        agregarPartidoGrilla(par);
                        numeroPartido++;
                    }

                }
            }
            btn_guardar.Enabled = false;
            if (numeroPartido - 1 == 1)
            {
                lbl_DatosFilas.Text = (numeroPartido - 1) + " PARTIDO ENCONTRADO";
            }
            else
            {
                lbl_DatosFilas.Text = (numeroPartido - 1) + " PARTIDOS ENCONTRADOS";
            }
        }

        public void InicializarVentana(int numero)
        {
            Text = "Semana Número " + Convert.ToString(numero);
        }

        private void btn_agregarPartido_Click(object sender, EventArgs e)
        {
            if (numeroPartido >= 30)
            {
                MessageBox.Show("No pueden añadirse más partidos a esta semana.");
            }
            else
            {
                AgregarPartido agregarPartido = new AgregarPartido(numeroPartido);
                agregarPartido.ShowDialog();
                Partido par = agregarPartido.Partido;
                if (par != null)
                {
                    agregarPartidoGrilla(par);
                    listaPartidos.Add(par);
                    numeroPartido++;
                    btn_guardar.Enabled = true;
                    if (numeroPartido - 1 == 1)
                    {
                        lbl_DatosFilas.Text = (numeroPartido - 1) + " PARTIDO ENCONTRADO";
                    }
                    else
                    {
                        lbl_DatosFilas.Text = (numeroPartido - 1) + " PARTIDOS ENCONTRADOS";
                    }
                }
            }

        }

        public void agregarPartidoGrilla(Partido par)
        {
            string goles = "";
            if (par.GolesFavor != par.GolesContra)
            {
                goles = Convert.ToString(par.GolesFavor) + " - " + Convert.ToString(par.GolesContra);
            }
            else
            {
                goles = Convert.ToString(par.GolesFavor) + " (" + Convert.ToString(par.PenalesFavor) + ") - (" + Convert.ToString(par.PenalesContra) + ") " + Convert.ToString(par.GolesContra);
            }
            dgv_partidos.Rows.Add(par.Numero, par.NombreRival, par.Resultado, goles, par.Localia);
        }


        private TextWriter archivoSemana(int numero)
        {
            TextWriter tw = new StreamWriter("Semanas/" + numero + ".txt");
            return tw;
        }

        public void cargarDatos(Semana semana)
        {
            TextWriter tw = archivoSemana(semana.Numero);
            cargaDatos.calcularDatos(semana);
            tw.WriteLine(semana.Numero + "*" + semana.Fecha + "*" + semana.Rango + "*" + semana.Ganados + "*" + semana.Perdidos + "*" + semana.Jugados);
            if (semana.Partidos != null)
            {
                foreach (Partido partido in semana.Partidos)
                {
                    tw.WriteLine(partido.Numero + "*" + partido.NombreRival + "*" + partido.Resultado + "*" + partido.GolesFavor + "*" + partido.GolesContra + "*" + partido.PenalesFavor + "*" + partido.PenalesContra + "*" + partido.Localia);
                }
            }
            tw.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            foreach (Partido partido in ListaPartidos)
            {
                semanaActual.Partidos.Add(partido);
            }
            cargarDatos(semanaActual);
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
