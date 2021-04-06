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
    public partial class GUIDespedirEmpleado : Form
    {
        public GUIDespedirEmpleado()
        {
            InitializeComponent();
            groupBoxSesion.Enabled = false;
            btnEliminar1.Visible = false;
            btnEliminar2.Visible = false;
            btnBuscarMesero.Visible = false;
            btnBuscarCajero.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectorPuntoVenta.SelectedIndex == 0) //Mesero
            {
                groupBoxSesion.Enabled = true;
                btnEliminar1.Visible = true;
                btnBuscarMesero.Visible = true;
                panel2.Enabled = false;
            }
            else if (SelectorPuntoVenta.SelectedIndex == 1) //Cajero
            {
                groupBoxSesion.Enabled = true;
                btnEliminar2.Visible = true;
                btnBuscarMesero.Visible = true;
                panel2.Enabled = false;
            }
        }

        private void btnBuscarMesero_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            Mesero retorno = GerentePunto.buscarMesero(cedula);

            txtNombre.Text = retorno.getNombre();
            txtCedulaBus.Text = Convert.ToString(retorno.getCedula());
            txtCelular.Text = Convert.ToString(retorno.getCelular());
            txtDireccion.Text = retorno.getDireccion();
            txtSalario.Text = Convert.ToString(retorno.getSalario());

        }

        private void btnBuscarCajero_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            Cajero retorno = GerentePunto.buscarCajero(cedula);

            txtNombre.Text = retorno.getNombre();
            txtCedulaBus.Text = Convert.ToString(retorno.getCedula());
            txtCelular.Text = Convert.ToString(retorno.getCelular());
            txtDireccion.Text = retorno.getDireccion();
            txtSalario.Text = Convert.ToString(retorno.getSalario());

        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            GerentePunto.despedirMesero(cedula);

            MessageBox.Show("Mesero eliminado correctamente");

            txtCedulaBus.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            GerentePunto.despedirMesero(cedula);

            MessageBox.Show("Cajero eliminado correctamente");

            txtCedulaBus.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();

        }
    }
}
