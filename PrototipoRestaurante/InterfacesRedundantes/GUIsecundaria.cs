using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRestaurante
{
    public partial class GUIsecundaria : Form
    {
        public GUIsecundaria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUIterciaria nueviti = new GUIterciaria();
            nueviti.Show();
        }

        private void GUIsecundaria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIcuartita nuevitis = new GUIcuartita();
            nuevitis.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
