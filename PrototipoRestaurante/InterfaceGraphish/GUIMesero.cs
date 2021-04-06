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
    public partial class GUIMesero : Form
    {
        public GUIMesero()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea cerrar la sesion?", "Advertencia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation);


            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

        }
    }
}
