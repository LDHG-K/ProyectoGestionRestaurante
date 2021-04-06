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
    public partial class GUIEliminarPlato : Form
    {
        public GUIEliminarPlato()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBuscado.Text);
            Plato retorno = MenuRestaurante.buscarPlato(id);


            txtId.Text = Convert.ToString(retorno.getNPlato());
            txtNombre.Text = retorno.getNombre();
            txtDescripcion.Text = retorno.getDescripcion();
            txtPrecio.Text = Convert.ToString(retorno.getPrecio());
            txtRuta.Text = retorno.getImagen();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBuscado.Text);
            MenuRestaurante.eliminarPlato(id);

            MessageBox.Show("Plato eliminado correctamente");
        }
    }
}
