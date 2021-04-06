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
    public partial class GerenteGeneral : Form
    {
       public GerenteGeneral()
        {
            InitializeComponent();
           /* JPanelRestaurante.Visible = false; */
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

        private void button2_Click(object sender, EventArgs e)
        {
            GUIContratarGerente gui = new GUIContratarGerente();
            gui.Show();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            GUIAgregarProveedor gui = new GUIAgregarProveedor();
            gui.Show();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            GUIBuscarProveedor gui = new GUIBuscarProveedor();
            gui.Show();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            GUIEliminarProveedor gui = new GUIEliminarProveedor();
            gui.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUIDespedirGerente gui = new GUIDespedirGerente();
            gui.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GUICalcularNomina gui = new GUICalcularNomina();
            gui.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            GUIProductosProveedor gui = new GUIProductosProveedor();
            gui.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GUIAgregarRestaurante gui = new GUIAgregarRestaurante();
            gui.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdBus.Text);
           Restaurante retorno =  GerenteGen.buscarRestaurante(id);

            txtNombre.Text = retorno.getNombre();
            txtId.Text = Convert.ToString( retorno.getId());
            txtTelefono.Text = Convert.ToString(retorno.getTelefono());
            txtDireccion.Text = retorno.getDireccion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUIGerenteInforme gui = new GUIGerenteInforme();
            gui.Show();
        }
    }
}

