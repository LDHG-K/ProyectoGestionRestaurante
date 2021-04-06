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
    public partial class GUIAgregarCliente : Form
    {
        public GUIAgregarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            int celular = Convert.ToInt32(txtCelular.Text);
            String correo = txtCcorreo.Text;

            Cajero.agregarCliente(nombre, cedula, celular, correo);

            MessageBox.Show("Cliente agregado correctamente");


        }
    }
}
