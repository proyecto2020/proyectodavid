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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'letrasDataSetGrado.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.letrasDataSetGrado.Grados);
            // TODO: esta línea de código carga datos en la tabla 'letrasDataSetGrupo.Grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.letrasDataSetGrupo.Grupos);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
