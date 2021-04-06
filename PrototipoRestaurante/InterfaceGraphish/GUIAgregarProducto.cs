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
    public partial class GUIAgregarProducto : Form
    {
        public GUIAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "c:\\";
            getImage.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg ";

            if(getImage.ShowDialog()== DialogResult.OK)
            {
                imagenProducto.ImageLocation = getImage.FileName;
                txtRuta.Text = getImage.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtId.Text);
            String nombre = txtNombre.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            String ruta = txtRuta.Text;

            Proveedor.agregarProducto(nombre,idProducto, precio, ruta);


            MessageBox.Show("Producto agregado correctamente");
        }
    }
}
