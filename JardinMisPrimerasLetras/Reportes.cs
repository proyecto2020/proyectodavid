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
    public partial class Reportes : Form
    {
        Reporte_Docente reporte_Docente = new Reporte_Docente();
        ReporteAlumno reporteAlumno = new ReporteAlumno();
        Reporte_Notas reporteNota = new Reporte_Notas();
        ReportePagos reportePagos = new ReportePagos();
        public Reportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.reporte_Docente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.reporteAlumno.Show();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //this.Hide();
            this.reporteNota.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //this.Hide();
            this.reportePagos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdministradorUsuarios administrador= new AdministradorUsuarios();
            Reportes reportes = new Reportes();
            administrador.Show();
            this.Hide();
        }
    }
}
