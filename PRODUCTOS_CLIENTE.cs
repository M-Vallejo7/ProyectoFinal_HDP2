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
using System.IO;

namespace Login._1
{
    public partial class frmPRODUCTOS_CLIENTE : Form
    {
        public frmPRODUCTOS_CLIENTE()
        {
            InitializeComponent();
            llenado();
        }
        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true"); string aux = "";
        public void llenado()
        {
            string consulta = "select * from PRODUCTO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtvproductos.DataSource = dt;
        }

        private void dtvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcantidad.Text = "1";
            aux = dtvproductos.SelectedCells[0].Value.ToString();
        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                int codigo = new int();
                SqlCommand cm = new SqlCommand("SELECT CANTIDAD FROM CARRITO WHERE CODIGO=@vcod", conexion);
                cm.Parameters.AddWithValue("@vcod", aux);
                SqlDataReader lct = cm.ExecuteReader();
                if (lct.Read())
                {
                    codigo = lct.GetInt32(0);
                    lct.Close();
                    SqlCommand cmd = new SqlCommand("SELECT CANTIDAD FROM PRODUCTO WHERE IDN=@vcod", conexion);
                    cmd.Parameters.AddWithValue("@vcod", aux);
                    SqlDataReader lector = cmd.ExecuteReader();
                    lector.Read();
                    if (Convert.ToInt32(txtcantidad.Text) <= lector.GetInt32(0) && codigo + Convert.ToInt32(txtcantidad.Text) <= lector.GetInt32(0))
                    {
                        lector.Close();
                        string consul = "update CARRITO set CANTIDAD=" + (codigo + Convert.ToInt32(txtcantidad.Text)) + " where CODIGO=" + aux;
                        SqlCommand comando = new SqlCommand(consul, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto añadido a el carrito");
                        conexion.Close();
                    }
                    else
                    {
                        lct.Close();
                        lector.Close();
                        MessageBox.Show("NO SE POSEE LA CANTIDAD");
                    }
                }
                else
                {
                    lct.Close();
                    SqlCommand cmd = new SqlCommand("SELECT CANTIDAD FROM PRODUCTO WHERE IDN=@vcod", conexion);
                    cmd.Parameters.AddWithValue("@vcod", aux);
                    SqlDataReader lector = cmd.ExecuteReader();
                    lector.Read();
                    if (Convert.ToInt32(txtcantidad.Text) <= lector.GetInt32(0))
                    {
                        lector.Close();
                        enviar_carrito();
                        MessageBox.Show("Producto añadido a el carrito");
                    }
                    else
                    {
                        lector.Close();
                        MessageBox.Show("NO SE POSEE LA CANTIDAD");
                    }
                }

                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("NO SE POSEE LA CANTIDAD");
            }
        }
        public void enviar_carrito()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT NOMBRE, PRECIO FROM PRODUCTO WHERE IDN=@vcod", conexion);
                cmd.Parameters.AddWithValue("@vcod", aux);
                SqlDataReader lector = cmd.ExecuteReader();
                lector.Read();
                SqlCommand comando = new SqlCommand("Insert Into CARRITO (CODIGO,NOMBRE,CANTIDAD,PRECIO,TOTAL) values(@vcodigo,@vnombre,@vcantidad,@vprecio,@vtotal)", conexion);
                comando.Parameters.AddWithValue("@vcodigo", aux);
                comando.Parameters.AddWithValue("@vnombre", lector.GetString(0));
                comando.Parameters.AddWithValue("@vcantidad", txtcantidad.Text);
                comando.Parameters.AddWithValue("@vprecio", lector.GetString(1));
                comando.Parameters.AddWithValue("@vtotal", Convert.ToInt32(lector.GetString(1)) * Convert.ToInt32(txtcantidad.Text));
                lector.Close();
                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("VUELVE A INTENTARLO");
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
