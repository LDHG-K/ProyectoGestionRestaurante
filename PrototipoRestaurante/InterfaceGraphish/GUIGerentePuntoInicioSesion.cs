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

namespace PrototipoRestaurante.InterfaceGraphish
{
    public partial class GUIGerentePuntoInicioSesion : Form
    {
        public GUIGerentePuntoInicioSesion()
        {
            InitializeComponent();
            txtClaveDeUsuario.PasswordChar = '*';
            txtClaveDeUsuario.MaxLength = 14;
            groupBoxSesion.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxSesion.Visible = true;
            panel2.Enabled = false;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            GUIGerenteDePunto gui = new GUIGerenteDePunto();

            try
            {
                string restaurante = ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(restaurante))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, contraseña FROM gerente_de_punto WHERE usuario='" + txtNombreUsuario.Text + "' AND contraseña='" + txtClaveDeUsuario.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            gui.Show();
                            MessageBox.Show("Login exitoso.");
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
