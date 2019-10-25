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

namespace FIFA_Stats
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void img_futChampions_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUT_Champions.PantallaPrincipal fut = new FUT_Champions.PantallaPrincipal();
            fut.ShowDialog();
        }

        private void img_futChampions_MouseEnter(object sender, EventArgs e)
        {
            img_futChampions.ImageLocation = "Imagenes/100_LogoFUTChampions_Mouse.png";
        }

        private void img_futChampions_MouseLeave(object sender, EventArgs e)
        {
            img_futChampions.ImageLocation = "Imagenes/100_LogoFUTChampions.png";
        }

        private void img_modoCarrera_MouseEnter(object sender, EventArgs e)
        {
            img_modoCarrera.ImageLocation = "Imagenes/100_LogoModoCarrera_Mouse.png";

        }

        private void img_modoCarrera_MouseLeave(object sender, EventArgs e)
        {
            img_modoCarrera.ImageLocation = "Imagenes/100_LogoModoCarrera.png";
        }
    }
}
