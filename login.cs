using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Login._1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true");
        private void btningresar_Click(object sender, EventArgs e)
        {
            logins();
        }
        public void logins()
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENA, CODIGO FROM PERSONA1 WHERE USUARIO=@vusuario AND CONTRASENA=@vcontrasena",conexion);
                comando.Parameters.AddWithValue("@vusuario",txtusuario.Text);
                comando.Parameters.AddWithValue("@vcontrasena", txtpass.Text);
                SqlDataReader lector = comando.ExecuteReader();
                        if(lector.Read())
                        {
                           
                           int cod = lector.GetInt32(2);
                           if(cod == 101)
                           {
                              PnlTitulo obje = new PnlTitulo();
                              obje.Show();
                              this.Hide();
                            }
                           else
                           {
                              Admi objet = new Admi();
                              objet.Show();
                              this.Hide();
                           }
                           
                        }
                        else
                        {
                            MessageBox.Show("Datos incorecctos");
                        }
                lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            frmRegistro obj = new frmRegistro();
            obj.Show();
            this.Hide();
        }

    }
}
