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
    public partial class GUIContratarGerente : Form
    {
        public GUIContratarGerente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            int celular = Convert.ToInt32(txtCelular.Text);
            String direccion = txtDireccion.Text;
            DateTime fecha = dateTimeFecha.Value;
            double salario = Convert.ToDouble(txtSalario.Text);

            GerenteGen.contratarGerente(nombre, cedula, celular, direccion, fecha, salario);

            agregarDataBase(cedula,nombre,celular);

            MessageBox.Show("Gerente de punto agregado correctamente");
        }

        private void agregarDataBase(int cedula,String nombre, int telefono)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString))
            {
                string sql = "INSERT INTO gerente_de_punto(id,usuario,contraseña) VALUES(@param1,@param2,@param3)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = cedula;
                    cmd.Parameters.Add("@param2", SqlDbType.NText, 50).Value = nombre;
                    cmd.Parameters.Add("@param3", SqlDbType.NText, 50).Value = telefono;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
