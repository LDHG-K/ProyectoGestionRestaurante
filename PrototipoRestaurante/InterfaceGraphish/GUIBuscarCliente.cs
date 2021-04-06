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
    public partial class GUIBuscarCliente : Form
    {
        public GUIBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaBus.Text);
            Cliente retorno = Cajero.buscarCliente(cedula);

            txtNombre.Text = retorno.getNombre();
            txtCedula.Text = Convert.ToString(retorno.getCedula());
            txtCelular.Text = Convert.ToString(retorno.getCelular());
            txtCorreo.Text = retorno.getCorreo();

        }
    }
}
