using Microsoft.Reporting.WinForms;
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
    public partial class GUIGerenteReporte : Form
    {
        public List<Datos> datos = new List<Datos>();
        public GUIGerenteReporte()
        {
            InitializeComponent();
        }

        private void GUIGerenteReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",datos) );
            this.reportViewer1.RefreshReport();
        }
    }
}
