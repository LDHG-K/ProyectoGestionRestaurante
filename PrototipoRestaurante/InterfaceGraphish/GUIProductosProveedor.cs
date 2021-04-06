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
    public partial class GUIProductosProveedor : Form
    {
        public GUIProductosProveedor()
        {
            InitializeComponent();
        }

        private void btnAguacate_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Aguacate");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Lechuga");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Tomate");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Limón");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Cebolla");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Huevo");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Fresa");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Pollo");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Carne");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listaProductos.Items.Add("Salmón");
        }
    }
}
