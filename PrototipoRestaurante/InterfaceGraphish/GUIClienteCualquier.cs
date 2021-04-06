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
    public partial class GUIClienteCualquier : Form
    {
        public GUIClienteCualquier()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtCedula.Text != "" && txtTelefono.Text != "")
            {

            }
            else{
                MessageBox.Show("Debe ingresar sus datos","Ingrese sus datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnReservarMesa_Click(object sender, EventArgs e)
        {
            GUICrearReserva gui = new GUICrearReserva();
            gui.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUICancelarReserva gui = new GUICancelarReserva();
            gui.Show();
        }
    }
}
