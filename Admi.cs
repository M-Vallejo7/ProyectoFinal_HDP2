using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login._1
{
    public partial class Admi : Form
    {
        public Admi()
        {
            InitializeComponent();
        }

        private void BtnpicCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnpicmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btnpicmax.Visible = false;
            Btnpicrestaurar.Visible = true;
        }

        private void Btnpicrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btnpicmax.Visible = true;
            Btnpicrestaurar.Visible = false;
        }

        private void Btnpicguardar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            abrirproductos(new frmPRODUCTOS_ADMI());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btnpicsalir_Click(object sender, EventArgs e)
        {
            frmlogin obj = new frmlogin();
            obj.Show();
            this.Close();
        }
        private void abrirproductos(object PRODUCTOS)
        {
            if(this.Pnlcontenedor.Controls.Count > 0)
            {
                this.Pnlcontenedor.Controls.RemoveAt(0);
                Form fh = PRODUCTOS as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Pnlcontenedor.Controls.Add(fh);
                this.Pnlcontenedor.Tag = fh;
                fh.Show();
            }
            else
            {
                Form fh = PRODUCTOS as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Pnlcontenedor.Controls.Add(fh);
                this.Pnlcontenedor.Tag = fh;
                fh.Show();
            }
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            if (Pnlcontenedor.Controls.Count > 0)
                Pnlcontenedor.Controls.RemoveAt(0);
            USUARIOS ventana2 = new USUARIOS();
            ventana2.TopLevel = false;
            ventana2.Dock = DockStyle.Fill;
            Pnlcontenedor.Controls.Add(ventana2);
            ventana2.Show();

        }
    }
}
