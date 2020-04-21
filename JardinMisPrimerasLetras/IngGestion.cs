using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioControler;

namespace JardinMisPrimerasLetras
{
    public partial class IngGestion : Form
    {
        private loginControler controlador;
        Pagos pagos = new Pagos();

        public IngGestion()
        {
            InitializeComponent();
            this.controlador = new UsuarioControler.loginControler();
        }

        private void comboBoxGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDocente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string grupo = textGrupos.Text;
            string area = textArea.Text;
            //string docente = MDocente.Text;
            string grado = textGrados.Text;
            string materia = textMateria.Text;
            //string salones = Salones.Text;

            Gestion insertarGestion = new Gestion();
            insertarGestion.grupo = grupo;
            insertarGestion.area = area;
            //insertarGestion.docente = docente;
            insertarGestion.grados = grado;
            insertarGestion.materia = materia;
            //insertarGestion.salones = salones;

            Respuesta<object> ingreso = this.controlador.insertarGestion(insertarGestion);

            MessageBox.Show("Datos guardados correctamente");

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'letrasDataSetGestion.Gestion' Puede moverla o quitarla según sea necesario.
            this.gestionTableAdapter.Fill(this.letrasDataSetGestion.Gestion);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.usuarioTableAdapter.FillBy(this.letrasDataSetDocente.Usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void docenteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.usuarioTableAdapter.Docente(this.letrasDataSetDocente.Usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void docenteToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.usuarioTableAdapter.Docente(this.letrasDataSetDocente.Usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MDocente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void docenteToolStripButton_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.pagos.Show();
        }
    }
}

