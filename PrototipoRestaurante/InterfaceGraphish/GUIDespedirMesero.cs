using PrototipoRestaurante.World;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRestaurante.InterfaceGraphish
{
    public partial class GUIDespedirMesero : Form
    {
        public GUIDespedirMesero()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            Mesero retorno = GerentePunto.buscarMesero(cedula);

            txtNombre.Text = retorno.getNombre();
            txtCedula.Text = Convert.ToString(retorno.getCedula());
            txtCelular.Text = Convert.ToString(retorno.getCelular());
            txtDireccion.Text = retorno.getDireccion();
            txtSalario.Text = Convert.ToString(retorno.getSalario());
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            GerentePunto.despedirMesero(cedula);

            MessageBox.Show("Mesero eliminado correctamente");

            txtCedulaBus.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCedulaBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
