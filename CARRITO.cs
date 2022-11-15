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
    public partial class frmCARRITO : Form
    {
        public frmCARRITO()
        {
            InitializeComponent();
            llenado();
        }
        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true"); string aux = "";
        public void llenado()
        {
            string consulta = "select * from CARRITO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtvproductos.DataSource = dt;
        }

        private void dtvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcantidad.Text = dtvproductos.SelectedCells[2].Value.ToString();
            aux = dtvproductos.SelectedCells[0].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT CANTIDAD FROM PRODUCTO WHERE IDN=@vcod", conexion);
                cmd.Parameters.AddWithValue("@vcod", aux);
                SqlDataReader lector = cmd.ExecuteReader();
                lector.Read();
                if (Convert.ToInt32(txtcantidad.Text) <= lector.GetInt32(0))
                {
                    lector.Close();
                    SqlCommand cm = new SqlCommand("SELECT PRECIO FROM CARRITO WHERE CODIGO=@vcod", conexion);
                    cm.Parameters.AddWithValue("@vcod", aux);
                    SqlDataReader lct = cm.ExecuteReader();
                    lct.Read();
                    string consul = "update CARRITO set CANTIDAD=" + txtcantidad.Text + ", TOTAL=" + (Convert.ToInt32(txtcantidad.Text) * lct.GetInt32(0)) + " where CODIGO=" + aux;
                    lct.Close();
                    SqlCommand comando = new SqlCommand(consul, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    llenado();
                }
                else
                {
                    MessageBox.Show("NO SE POSEE LA CANTIDAD");
                    conexion.Close();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("NO SE POSEE LA CANTIDAD");
            }
            txtcantidad.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "delete from CARRITO where CODIGO=" + aux + "";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                llenado();
                conexion.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("NO SE ELIMINO");
            }
            aux = "";
            txtcantidad.Text = "";
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                int suma_total = 0;
                foreach (DataGridViewRow dr in dtvproductos.Rows)
                {
                    string consulta = "select PRODUCTO.* from PRODUCTO inner join CARRITO on PRODUCTO.IDN=CARRITO.CODIGO update PRODUCTO set PRODUCTO.CANTIDAD =PRODUCTO.CANTIDAD-" + dr.Cells[2].Value + " Where PRODUCTO.IDN=" + dr.Cells[0].Value;
                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.ExecuteNonQuery();
                    suma_total = suma_total + Convert.ToInt32(dr.Cells[4].Value);
                }
                MessageBox.Show("Total a pagar= " + suma_total);
                string consult = "delete from CARRITO";
                SqlCommand cm = new SqlCommand(consult, conexion);
                cm.ExecuteNonQuery();
                conexion.Close();
                llenado();
                aux = "";
                txtcantidad.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("NO SE EFECTUO LA COMPRA");
            }
        }
    }
}
