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
    public partial class GUIAgregarRestaurante : Form
    {
        public GUIAgregarRestaurante()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( txtId.Text);
            int telefono= Convert.ToInt32(txtTelefono.Text);
            String direccion = txtDireccion.Text;
            String nombre = txtNombre.Text;

            GerenteGen.agregarRestaurante(id, telefono, direccion, nombre);

            MessageBox.Show("Restaurante agregado correctamente");

        }


    }
}
