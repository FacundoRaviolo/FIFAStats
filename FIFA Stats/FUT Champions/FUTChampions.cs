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
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;

namespace FIFA_Stats.FUT_Champions
{
    public partial class FUTChampions : Form
    {
        Bitmap imagen = new Bitmap("Imagenes/35_Rango.png");
        private bool yaSeAbrio = false;
        private List<String[]> listaDatos = new List<String[]>();

        private CargaDatos cargaDatos = new CargaDatos();
        private int numero = 1;
        private List<Semana> listaSemanas = new List<Semana>();

        public List<Semana> ListaSemanas { get => listaSemanas; set => listaSemanas = value; }

        public FUTChampions()
        {
            InitializeComponent();
            dgv_semanas.EnableHeadersVisualStyles = false;
            dgv_semanas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_semanas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10,56,85);
            dgv_semanas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_semanas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_semanas.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_semanas.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_semanas.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_semanas.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            if (!yaSeAbrio)
            {
                obtenerDatosGuardados();
            }
            else
            {
                listaDatos.Clear();
                obtenerDatosGuardados();
            }
            yaSeAbrio = true;
            recuperarDatos(listaDatos);
            btn_Actualizar.Enabled = false;
            
            string cantSemanas = Convert.ToString(listaSemanas.Count);
            if (cantSemanas == "1")
            {
                lbl_DatosFilas.Text = cantSemanas + " SEMANA ENCONTRADA";
            }
            else
            {
                lbl_DatosFilas.Text = cantSemanas + " SEMANAS ENCONTRADAS";

            }
        }

        private void abrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor2.Controls.Count > 0)
            {
                this.panelContenedor2.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor2.Controls.Add(fh);
            this.panelContenedor2.Tag = fh;
            fh.Show();
        }

        private void btn_agregarsemana_Click(object sender, EventArgs e)
        {
            AgregarSemana agregarSemana = new AgregarSemana(numero);
            agregarSemana.ShowDialog();
            Semana sem = agregarSemana.Semana;
            if (sem != null)
            {
                agregarSemanaGrilla(sem);
                listaSemanas.Add(sem);
                cargaDatos.cargarDatos(sem);
                cargaDatos.guardarCantidadSemanas(listaSemanas);
                numero++;
                string cantSemanas = Convert.ToString(listaSemanas.Count);
                if (cantSemanas == "1")
                {
                    lbl_DatosFilas.Text = cantSemanas + " SEMANA ENCONTRADA";
                }
                else
                {
                    lbl_DatosFilas.Text = cantSemanas + " SEMANAS ENCONTRADAS";
                }
            }
        }

        public void agregarSemanaGrilla(Semana sem)
        {
            string url = definirImagenRango(sem.Rango);
            object imagen = @"Imagenes/" + url;
            object imgVer = @"Imagenes/botonOjo.png";
            object imgEliminar = @"Imagenes/botonEliminar.png";
            dgv_semanas.Rows.Add(sem.Numero, sem.Fecha, imagen, sem.Rango, sem.Ganados, sem.Perdidos, sem.Jugados, imgVer, imgEliminar);
        }

        private void dgv_semanas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_semanas.Columns[e.ColumnIndex].Name == "Ver")
            {
                int numero = Convert.ToInt32(dgv_semanas.CurrentRow.Cells[0].Value.ToString());
                VerSemana verSemana = new VerSemana(numero, ListaSemanas);
                abrirFormEnPanel(verSemana);
                btn_Actualizar.Enabled = true;
            }

            if (dgv_semanas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int numero = Convert.ToInt32(dgv_semanas.CurrentRow.Cells[0].Value.ToString());
                DialogResult resultado;
                resultado = MessageBox.Show("¿Desea eliminar la semana " + numero + "?","Semana " + numero,MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    Semana index = null;
                    foreach (Semana semana in listaSemanas)
                    {
                        if (semana.Numero == numero)
                        {
                            index = semana;
                        }
                    }
                    listaSemanas.Remove(index);
                    File.Delete("Semanas/" + numero + ".txt");
                    cargaDatos.guardarCantidadSemanas(listaSemanas);
                    dgv_semanas.Rows.RemoveAt(dgv_semanas.CurrentRow.Index);
                    string cantSemanas = Convert.ToString(listaSemanas.Count);
                    if (cantSemanas == "1")
                    {
                        lbl_DatosFilas.Text = cantSemanas + " SEMANA ENCONTRADA";
                    }
                    else
                    {
                        lbl_DatosFilas.Text = cantSemanas + " SEMANAS ENCONTRADAS";
                    }
                }
            }
        }


        public void recuperarDatos(List<string[]> listaDatos)
        {
            for (int i = 0; i < listaDatos.Count; i++)
            {
                string[] datosSemana = listaDatos[i][0].Split('*');

                Semana semana = new Semana();
                semana.Numero = Convert.ToInt32(datosSemana[0]);
                semana.Fecha = datosSemana[1];
                semana.Rango = datosSemana[2];
                semana.Ganados = Convert.ToInt32(datosSemana[3]);
                semana.Perdidos = Convert.ToInt32(datosSemana[4]);
                semana.Jugados = Convert.ToInt32(datosSemana[5]);
                semana.Partidos = new List<Partido>();

                for (int j = 1; j < listaDatos[i].Length; j++)
                {
                    string[] datosPartido = listaDatos[i][j].Split('*');

                    Partido partido = new Partido();
                    partido.Numero = Convert.ToInt32(datosPartido[0]);
                    partido.NombreRival = datosPartido[1];
                    partido.Resultado = datosPartido[2];
                    partido.GolesFavor = Convert.ToInt32(datosPartido[3]);
                    partido.GolesContra = Convert.ToInt32(datosPartido[4]);
                    partido.PenalesFavor = Convert.ToInt32(datosPartido[5]);
                    partido.PenalesContra = Convert.ToInt32(datosPartido[6]);
                    partido.Localia = datosPartido[7];

                    semana.Partidos.Add(partido);
                }
                listaSemanas.Add(semana);
                agregarSemanaGrilla(semana);
                numero++;
            }
        }

        public void obtenerDatosGuardados()
        {
            var archivos = new List<String>(System.IO.Directory.GetFiles("Semanas", "*.txt"));
            archivos.Sort((x, y) => ExtractNumber(x).CompareTo(ExtractNumber(y)));
            foreach (string archivo in archivos)
            {
                string[] datos = File.ReadAllLines(archivo);
                listaDatos.Add(datos);
            }
        }

        static int ExtractNumber(string text)
        {
            Match match = Regex.Match(text, @"(\d+)");
            if (match == null)
            {
                return 0;
            }

            int value;
            if (!int.TryParse(match.Value, out value))
            {
                return 0;
            }

            return value;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            dgv_semanas.Rows.Clear();
            numero = 1;
            listaSemanas.Clear();
            listaDatos.Clear();
            obtenerDatosGuardados();
            recuperarDatos(listaDatos);
            btn_Actualizar.Enabled = false;
        }

        private void dgv_semanas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgv_semanas.Columns[e.ColumnIndex].Name)
            {
                case "IconoRango":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {

                            e.Value = null;
                        }
                    }
                    break;
                case "Ver":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {

                            e.Value = null;
                        }
                    }
                    break;
                case "Eliminar":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {

                            e.Value = null;
                        }
                    }
                    break;
            }
        }

        private string definirImagenRango(string rango)
        {
            string nombre = "";

            if (rango == "Por determinar")
            {
                nombre = "35_SinRango.png";
            }
            else
            {
                nombre = "35_" + rango.Replace(" ","") + ".png";
            }

            return nombre;
        }

        private void dgv_semanas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int numero = Convert.ToInt32(dgv_semanas.CurrentRow.Cells[0].Value.ToString());
                VerSemana verSemana = new VerSemana(numero, ListaSemanas);
                abrirFormEnPanel(verSemana);
                btn_Actualizar.Enabled = true;
            }

        }

        private void dgv_semanas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 2)
            {
                e.Graphics.DrawImage(imagen, e.CellBounds);
                e.Handled = true;
            }
        }

        private void btn_Actualizar_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_Actualizar.Enabled)
            {
                btn_Actualizar.BackColor = Color.FromArgb(27, 76, 122);
                btn_Actualizar.ForeColor = Color.White;
            }
            else
            {
                btn_Actualizar.BackColor = Color.FromArgb(204, 204, 204);
                btn_Actualizar.ForeColor = Color.FromArgb(175, 175, 175);
            }
        }

        private void btn_Actualizar_Paint(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            var drawBrush = new SolidBrush(btn.ForeColor);
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            btn_Actualizar.Text = string.Empty;
            e.Graphics.DrawString("Actualizar", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
    }
}
