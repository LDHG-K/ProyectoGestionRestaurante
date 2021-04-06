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
    public partial class GUIMeseroInicioSesion : Form
    {
        public GUIMeseroInicioSesion()
        {
            InitializeComponent();
            txtClaveDeUsuario.PasswordChar = '*';
            txtClaveDeUsuario.MaxLength = 14;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            GUIMesero gui = new GUIMesero();

            try
            {
                string restaurante = ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(restaurante))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, contraseña FROM mesero WHERE usuario='" + txtNombreUsuario.Text + "' AND contraseña='" + txtClaveDeUsuario.Text + "'", conexion))
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
    }
}
