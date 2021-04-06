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
    public partial class GUICajero : Form
    {
        public GUICajero()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            GUIBuscarCliente GUI = new GUIBuscarCliente();
            GUI.Show();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            GUIAgregarCliente GUI = new GUIAgregarCliente();
            GUI.Show();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            GUIGerenteInforme GUI = new GUIGerenteInforme();
            GUI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnPagarPedido_Click(object sender, EventArgs e)
        {

        }
    }
}
