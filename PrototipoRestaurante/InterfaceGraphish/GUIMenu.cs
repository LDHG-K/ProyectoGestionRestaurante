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
    public partial class GUIMenu : Form
    {
        public GUIMenu()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUIAgregarPlato gui = new GUIAgregarPlato();
            gui.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GUIEliminarPlato gui = new GUIEliminarPlato();
            gui.Show();
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Clear();

            List<Plato> platos = MenuRestaurante.darListaPlatos();

            for (int i = 0; i < platos.Count; i++)
            {
                listaProductos.Items.Add(platos[i].getNombre());
            }
        }
    }
}
