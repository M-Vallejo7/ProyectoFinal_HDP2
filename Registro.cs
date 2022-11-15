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

namespace Login._1
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true");
        

        private void btnregistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "" && txtid.Text != "" && txtcorreo.Text != "" && txtcontrasena.Text != "" && txtconfirmacion.Text != "")
                {
                    if (txtcontrasena.Text == txtconfirmacion.Text)
                    {
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("Insert Into PERSONA1 (USUARIO,CONTRASENA,CODIGO,CORREO,ID) values(@vusuario,@vcontrasena,101,@vCORREO,@vID) ", conexion);
                        comando.Parameters.AddWithValue("@vusuario", txtnombre.Text);
                        comando.Parameters.AddWithValue("@vcontrasena", txtconfirmacion.Text);
                        comando.Parameters.AddWithValue("@vCORREO", txtcorreo.Text);
                        comando.Parameters.AddWithValue("@vID", txtid.Text);
                        comando.ExecuteNonQuery();
                        conexion.Close();
                        frmlogin obj = new frmlogin();
                        obj.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("La contraseña no coincide");
                    }

                }
                else
                {
                    MessageBox.Show("Hay campos de texto vacios");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(Convert.ToString(z));

            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return;
            }
        }
    }
}