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
    public partial class GUIGerenteDePunto : Form
    {
        public GUIGerenteDePunto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIContratarEmpleado gui = new GUIContratarEmpleado();
            gui.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUIMenu gui = new GUIMenu();
            gui.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUIClienteCualquier gui = new GUIClienteCualquier();
            gui.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea cerrar la sesion?", "Advertencia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation);


            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GUIGerenteInforme gui = new GUIGerenteInforme();
            gui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUIDespedirEmpleado gui = new GUIDespedirEmpleado();
            gui.Show();
        }
    }
}
