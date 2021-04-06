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
    public partial class GUIAgregarPlato : Form
    {
        public GUIAgregarPlato()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "c:\\";
            getImage.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg ";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imagenProducto.ImageLocation = getImage.FileName;
                txtRuta.Text = getImage.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nPlato = Convert.ToInt32(txtId.Text);
            String nombre = txtNombre.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            String descripcion = txtDescripción.Text;
            String ruta = txtRuta.Text;

            MenuRestaurante.agregarPlato(nombre, descripcion, precio, nPlato, ruta);

            MessageBox.Show("Plato agregado");
        }
    }
}
