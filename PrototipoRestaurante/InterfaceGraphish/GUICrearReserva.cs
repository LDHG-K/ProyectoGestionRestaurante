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
    public partial class GUICrearReserva : Form
    {
        public GUICrearReserva()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int numReserva = Convert.ToInt32( txtNumReserva.Text);
            DateTime fecha = dateFecha.Value;

            GerentePunto.crearReserva( fecha, numReserva);

            MessageBox.Show("Reserva creada");
        }

    }
}
