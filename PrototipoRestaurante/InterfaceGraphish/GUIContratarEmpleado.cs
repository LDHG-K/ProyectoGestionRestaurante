using PrototipoRestaurante.World;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRestaurante.InterfaceGraphish
{
    public partial class GUIContratarEmpleado : Form
    {
        public GUIContratarEmpleado()
        {
            InitializeComponent();
            groupBoxSesion.Enabled = false;
            btnAgregar1.Visible = false;
            btnAgregar2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectorPuntoVenta.SelectedIndex == 0) //Mesero
            {
                groupBoxSesion.Enabled = true;
                btnAgregar1.Visible = true;
                panel2.Enabled = false;
            }
            else if (SelectorPuntoVenta.SelectedIndex == 1) //Cajero
            {
                groupBoxSesion.Enabled = true;
                btnAgregar2.Visible = true;
                panel2.Enabled = false;
            }
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            int celular = Convert.ToInt32(txtCelular.Text);
            String direccion = txtDireccion.Text;
            DateTime fecha = dateTimeFecha.Value;
            double salario = Convert.ToDouble(txtSalario.Text);

            GerentePunto.contratarMesero(nombre, cedula, celular, direccion, fecha, salario);
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString))
            {
                string sql = "INSERT INTO mesero(id,usuario,contraseña) VALUES(@param1,@param2,@param3)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value= cedula;
                    cmd.Parameters.Add("@param2", SqlDbType.NText, 50).Value= nombre;
                    cmd.Parameters.Add("@param3", SqlDbType.NText, 50).Value = celular;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }

                MessageBox.Show("Mesero agregado correctamente");
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            int celular = Convert.ToInt32(txtCelular.Text);
            String direccion = txtDireccion.Text;
            DateTime fecha = dateTimeFecha.Value;
            double salario = Convert.ToDouble(txtSalario.Text);

            GerentePunto.contratarCajero(nombre, cedula, celular, direccion, fecha, salario);
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString))
            {
                string sql = "INSERT INTO cajero(id,usuario,contraseña) VALUES(@param1,@param2,@param3)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = cedula;
                    cmd.Parameters.Add("@param2", SqlDbType.NText, 50).Value = nombre;
                    cmd.Parameters.Add("@param3", SqlDbType.NText, 50).Value = celular;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cajero agregado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
