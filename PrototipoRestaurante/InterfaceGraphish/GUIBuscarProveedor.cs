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
    public partial class GUIBuscarProveedor : Form
    {
        public GUIBuscarProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre =txtNombreBus.Text;
            Proveedor retorno = GerenteGen.buscarProveedor(nombre);

            txtNombre.Text = retorno.getNombre();
            txtDireccion.Text = retorno.getDireccion();
            txtTelefono.Text = Convert.ToString(retorno.getTelefono());


        }
    }
}
