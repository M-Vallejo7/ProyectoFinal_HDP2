using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Login._1
{
    public partial class USUARIOS : Form
    {
        public USUARIOS()
        {
            InitializeComponent();
            llenado();
        }
        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true");
        public void llenado()
        {
            string consulta = "select * from PERSONA1";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtvUSUARIOS.DataSource = dt;
        }
        private void dtvUSUARIOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDN.Text = dtvUSUARIOS.SelectedCells[0].Value.ToString();
            txtnombre.Text = dtvUSUARIOS.SelectedCells[1].Value.ToString();
            txtcontrasena.Text = dtvUSUARIOS.SelectedCells[2].Value.ToString();
            txtcodigo.Text = dtvUSUARIOS.SelectedCells[3].Value.ToString();
            txtcorreo.Text = dtvUSUARIOS.SelectedCells[4].Value.ToString();
            txtid.Text = dtvUSUARIOS.SelectedCells[5].Value.ToString();
        }
        public void borrar()
        {
            txtIDN.Text = "";
            txtcontrasena.Text = "";
            txtnombre.Text = "";
            txtcodigo.Text = "";
            txtcorreo.Text = "";
            txtid.Text = "";
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "" && txtcontrasena.Text != "" && txtcorreo.Text != "")
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Insert Into PERSONA1 (USUARIO,CONTRASENA,CODIGO,CORREO,ID) values(@vusuario,@vcontrasena,@vcodigo,@vcorreo,@vid) ", conexion);
                    comando.Parameters.AddWithValue("@vusuario", txtnombre.Text);
                    comando.Parameters.AddWithValue("@vcontrasena", txtcontrasena.Text);
                    comando.Parameters.AddWithValue("@vcodigo", txtcodigo.Text);
                    comando.Parameters.AddWithValue("@vcorreo", txtcorreo.Text);
                    comando.Parameters.AddWithValue("@vid", txtid.Text);

                    comando.ExecuteNonQuery();
                    llenado();
                    conexion.Close();
                    borrar();
                }
                else
                {
                    MessageBox.Show("HAY CAMPOS DE TEXTOS VACIOS");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consul = "update PERSONA1 set USUARIO='" + txtnombre.Text + "',CONTRASENA='" + txtcontrasena.Text + "',CODIGO=" + txtcodigo.Text + ",CORREO='" + txtcorreo.Text + "',ID=" + txtid.Text + " where IDN=" + txtIDN.Text;
                SqlCommand cmd = new SqlCommand(consul, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario modificado");
                conexion.Close();
                llenado();
                borrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario no se modifico");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "delete from PERSONA1 where IDN=" + txtIDN.Text+ "";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado");
                llenado();
                conexion.Close();
                borrar();
            }
            catch (Exception)
            {
                MessageBox.Show("El producto no se elimino");

            }
        }

       
    }
}
