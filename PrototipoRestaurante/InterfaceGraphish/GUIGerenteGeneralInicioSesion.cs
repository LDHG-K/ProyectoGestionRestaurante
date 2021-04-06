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
    public partial class GUIGerenteGeneralInicioSesion : Form
    {
        public GUIGerenteGeneralInicioSesion()
        {
            InitializeComponent();
            // Set to no text.

            // The password character is an asterisk.
            txtClaveDeUsuario.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtClaveDeUsuario.MaxLength = 14;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            /*GUIRestauranteGerente gui = new GUIRestauranteGerente();
             * */
            GerenteGeneral gui = new GerenteGeneral();
             

            try
            {
                string restaurante = ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(restaurante))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, contraseña FROM gerente_Principal WHERE usuario='" + txtNombreUsuario.Text + "' AND contraseña='" + txtClaveDeUsuario.Text + "'", conexion))
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
    }
}
