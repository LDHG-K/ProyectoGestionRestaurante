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
    public partial class GUICancelarReserva : Form
    {
        public GUICancelarReserva()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numReserva = Convert.ToInt32(txtNumeroBus.Text);
            Reserva retorno= GerentePunto.buscarReserva(numReserva);

            txtNumReserva.Text = Convert.ToString(retorno.getNReserva());
            dateFecha.Value = retorno.getFecha();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int numReserva = Convert.ToInt32(txtNumeroBus.Text);
            GerentePunto.elimarReserva(numReserva);

            MessageBox.Show("Reserva cancelada");

            txtNumReserva.Clear();
            txtNumeroBus.Clear();
            
        }
    }
}
