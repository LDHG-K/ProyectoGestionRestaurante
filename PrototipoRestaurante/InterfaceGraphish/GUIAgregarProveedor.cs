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
    public partial class GUIAgregarProveedor : Form
    {
        public GUIAgregarProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            long telefono = Convert.ToInt64(txtTelefono.Text);
            String direccion = txtDireccion.Text;


            GerenteGen.agregarProveedor(nombre, direccion,telefono);

            MessageBox.Show("Proveedor agregado correctamente");
           
        }
    }
}
