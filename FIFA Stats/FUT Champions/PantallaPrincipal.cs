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
using System.Runtime.InteropServices;

namespace FIFA_Stats.FUT_Champions
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            sombra_semanas.Hide();
            sombra_estadisticas.Hide();
            abrirFormEnPanel(new Inicio());
        }

        private void abrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count>0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_verSemanas_Click(object sender, EventArgs e)
        {
            sombra_semanas.Show();
            sombra_inicio.Hide();
            sombra_estadisticas.Hide();
            abrirFormEnPanel(new FUTChampions());
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            sombra_estadisticas.Show();
            sombra_inicio.Hide();
            sombra_semanas.Hide();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            sombra_inicio.Show();
            sombra_estadisticas.Hide();
            sombra_semanas.Hide();
            abrirFormEnPanel(new Inicio());
        }
    }
}
