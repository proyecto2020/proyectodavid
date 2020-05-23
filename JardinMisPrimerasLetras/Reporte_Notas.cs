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
    public partial class Reporte_Notas : Form
    {
        public Reporte_Notas()
        {
            InitializeComponent();
        }

        private void Reporte_Notas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporte.Notas' Puede moverla o quitarla según sea necesario.
            this.NotasTableAdapter.Nota(this.DataSetReporte.Notas);

            this.reportViewer1.RefreshReport();
        }
    }
}
