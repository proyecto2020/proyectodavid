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
    public partial class ReporteAlumno : Form
    {
        public ReporteAlumno()
        {
            InitializeComponent();
        }

        private void ReporteAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporte.Alum_Nota' Puede moverla o quitarla según sea necesario.
            this.Alum_NotaTableAdapter.Alum_Nota(this.DataSetReporte.Alum_Nota);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporte.Usu_Asig' Puede moverla o quitarla según sea necesario.
            this.Usu_AsigTableAdapter.Usu_Asig(this.DataSetReporte.Usu_Asig);

            this.reportViewer1.RefreshReport();
        }
    }
}
