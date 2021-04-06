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
    public partial class GUIChef : Form
    {
        public GUIChef()
        {
            InitializeComponent();
        }

        private void BtnVerMenu_Click(object sender, EventArgs e)
        {
            GUIMenu GUI = new GUIMenu();
            GUI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
