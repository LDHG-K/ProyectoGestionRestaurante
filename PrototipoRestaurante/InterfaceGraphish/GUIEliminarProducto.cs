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
    public partial class GUIEliminarProducto : Form
    {
        public GUIEliminarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBuscado.Text);
           Producto retorno=  Proveedor.buscarProducto(id);

            txtId.Text = Convert.ToString(retorno.getIdProducto());
            txtNombre.Text = retorno.getNombre();
            txtPrecio.Text = Convert.ToString(retorno.getPrecio());
            txtRuta.Text = retorno.getImagen(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBuscado.Text);
            Proveedor.eliminarProducto(id);

            MessageBox.Show("Producto eliminado");

            txtIdBuscado.Clear();
            txtId.Clear();
            txtPrecio.Clear();
            txtRuta.Clear();
        }
    }
}
