using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoRestaurante.InterfaceGraphish;

namespace PrototipoRestaurante
{
    public partial class GUIprincipal : Form
    {
        public GUIprincipal()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void gerenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIGerenteGeneralInicioSesion guiM = new GUIGerenteGeneralInicioSesion();
            guiM.Show();
        }

        private void gerenteDePuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIGerentePuntoInicioSesion gui = new GUIGerentePuntoInicioSesion();
            gui.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GUIprincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarCliente gui = new GUIAgregarCliente();
            gui.Show(); 
        }

        private void crearPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIPruebaPedido gui = new GUIPruebaPedido();
            gui.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarCliente gui = new GUIBuscarCliente();
            gui.Show();
        }

        private void despedirMeseroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDespedirMesero gui = new GUIDespedirMesero();
            gui.Show();
        }

        private void despedirCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDespedirCajero gui = new GUIDespedirCajero();
            gui.Show();
        }

        private void agregarProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarProveedor gui = new GUIAgregarProveedor();
            gui.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIClienteCualquier gui = new GUIClienteCualquier();
            gui.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarProducto gui = new GUIAgregarProducto();
            gui.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIEliminarProducto gui = new GUIEliminarProducto();
            gui.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIMenu gui = new GUIMenu();
            gui.Show();
        }

        private void meseroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIMeseroInicioSesion gui = new GUIMeseroInicioSesion();
            gui.Show();
        }

        private void chefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIChefInicioSesion gui = new GUIChefInicioSesion();
            gui.Show();
        }

        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUICajeroInicioSesion gui = new GUICajeroInicioSesion();
            gui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUIClienteCualquier gui = new GUIClienteCualquier();
            gui.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIsecundaria nueva = new GUIsecundaria();
            nueva.Show();
        }
    }
}

