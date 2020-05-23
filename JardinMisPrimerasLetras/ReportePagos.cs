using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JardinMisPrimerasLetras
{
    public partial class ReportePagos : Form
    {
        public ReportePagos()
        {
            InitializeComponent();
        }

        private void ReportePagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporte.Pagos' Puede moverla o quitarla según sea necesario.
            this.PagosTableAdapter.Pagos(this.DataSetReporte.Pagos);

            this.reportViewer1.RefreshReport();
        }
    }
}
