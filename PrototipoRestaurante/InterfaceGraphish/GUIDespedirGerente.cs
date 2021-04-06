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
    public partial class GUIDespedirGerente : Form
    {
        public GUIDespedirGerente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            GerentePunto retorno = GerenteGen.buscarGerente(cedula);

            txtNombre.Text = retorno.getNombre();
            txtCedula.Text = Convert.ToString(retorno.getCedula());
            txtCelular.Text = Convert.ToString(retorno.getCelular());
            txtDireccion.Text = retorno.getDireccion();
            txtSalario.Text = Convert.ToString(retorno.getSalario());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            GerenteGen.despedirGerente(cedula);

            MessageBox.Show("Gerente de punto eliminado correctamente");

            txtCedulaBus.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();
        }
    }
}
