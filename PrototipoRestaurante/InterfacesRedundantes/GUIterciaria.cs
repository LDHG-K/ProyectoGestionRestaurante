using PrototipoRestaurante.InterfaceGraphish;
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
    public partial class GUIterciaria : Form
    {
        public GUIterciaria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GUIsecundaria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIMeseroInicioSesion gui = new GUIMeseroInicioSesion();
            gui.Show();
        }

        private void buttonMesi_Click(object sender, EventArgs e)
        {
            GUIMeseroInicioSesion gui = new GUIMeseroInicioSesion();
            gui.Show();
        }

        private void buttonChif_Click(object sender, EventArgs e)
        {
            GUIChefInicioSesion gui = new GUIChefInicioSesion();
            gui.Show();
        }

        private void buttonCaji_Click(object sender, EventArgs e)
        {
            GUICajeroInicioSesion gui = new GUICajeroInicioSesion();
            gui.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
