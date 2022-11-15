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
    public partial class frmPRODUCTOS_ADMI : Form
    {
        public frmPRODUCTOS_ADMI()
        {
            InitializeComponent();
            llenado();
        }
        SqlConnection conexion = new SqlConnection(@"server =localhost\SQLEXPRESS ; database = SISTEMA ; INTEGRATED SECURITY=true");
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
            txtcodigo.Text = dtvproductos.SelectedCells[0].Value.ToString();
            txtnombre.Text = dtvproductos.SelectedCells[1].Value.ToString();
            txtcantidad.Text = dtvproductos.SelectedCells[3].Value.ToString();
            txtprecio.Text = dtvproductos.SelectedCells[2].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "delete from PRODUCTO where IDN=" + txtcodigo.Text + "";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado");
                llenado();
                conexion.Close();
                borrar();
            }
            catch (Exception)
            {

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnombre.Text!=""&&txtcantidad.Text!=""&&txtprecio.Text!="")
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Insert Into PRODUCTO (NOMBRE,PRECIO,CANTIDAD) values(@vnombre,@vprecio,@vcantidad) ", conexion);
                    comando.Parameters.AddWithValue("@vnombre", txtnombre.Text);
                    comando.Parameters.AddWithValue("@vprecio", txtprecio.Text);
                    comando.Parameters.AddWithValue("@vcantidad", txtcantidad.Text);
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

            }

        }
        public void borrar()
        {
            txtcantidad.Text = "";
            txtnombre.Text = "";
            txtcodigo.Text = "";
            txtprecio.Text = "";
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consul = "update PRODUCTO set NOMBRE='" + txtnombre.Text + "',PRECIO=" + txtprecio.Text + ",CANTIDAD=" + txtcantidad.Text + " where IDN=" + txtcodigo.Text;
                SqlCommand cmd = new SqlCommand(consul, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
                conexion.Close();
                llenado();
                borrar();
            }
            catch (Exception)
            {

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

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return;
            }
        }

        private void btnimportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if(abrir.ShowDialog()== DialogResult.OK)
            {
                string direccion = abrir.FileName;
                try
                {
                    StreamReader sr = new StreamReader(direccion);
                    string linea = "";
                    linea = sr.ReadLine();
                    if (linea != null)
                    {
                        List<PRODUCTOS> aux = new List<PRODUCTOS>();
                        while (linea != null)
                        {
                            string[] dato = linea.Split(new char[] { ';' });
                            linea = sr.ReadLine();
                            aux.Add(new PRODUCTOS(dato[0],dato[1],dato[2]));
                        }
                        sr.Close();
                        SqlCommand comando = new SqlCommand("Insert Into PRODUCTO (NOMBRE,PRECIO,CANTIDAD) values(@vnombre,@vprecio,@vcantidad) ", conexion);
                        conexion.Open();
                        foreach ( PRODUCTOS  p in aux)
                        {
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@vnombre", p.nombre);
                            comando.Parameters.AddWithValue("@vprecio", p.precio);
                            comando.Parameters.AddWithValue("@vcantidad", p.cantidad);
                            comando.ExecuteNonQuery();
                        }
                        conexion.Close();
                        llenado();
                        borrar();
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }
    }
}
