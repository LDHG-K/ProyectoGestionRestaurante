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
    public partial class GUIGerenteInforme : Form
    {
        public GUIGerenteInforme()
        {
            InitializeComponent();
        }

        private void GUIGerenteInforme_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            GUIGerenteReporte gui = new GUIGerenteReporte();
            datos.nombre = textBox1.Text;
            datos.cargo = textBox2.Text;
            datos.asunto = textBox3.Text;
            gui.datos.Add(datos);
            gui.Show();
        }
    }
}
