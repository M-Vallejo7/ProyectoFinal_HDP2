﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;

namespace Login._1
{
    public partial class PnlTitulo : Form
    {
        public PnlTitulo()
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
            picmax.Visible = false;
            picrestaurar.Visible = true;
        }

        private void Btnpicrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picmax.Visible = true;
            picrestaurar.Visible = false;
        }

        private void Btnpicguardar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            abrirproductos(new frmPRODUCTOS_CLIENTE());
        }
        private void abrirproductos(object PRODUCTOS)
        {
            if (this.Pnlcontenedor.Controls.Count > 0)
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true"); private void Btnpicsalir_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from CARRITO";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            frmlogin obj = new frmlogin();
            obj.Show();
            this.Close();
        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            abrirproductos(new frmCARRITO());
        }
    }
}
