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
        List<Grados> listarGrados = null;
        List<Grupos> listarGrupos = null;
        List<Areas> listaAreas = null;
        List<Materias> listaMaterias = null;
        loginControler controladorAreasMateria = new loginControler();
        loginControler controladorGradosGrupos = new loginControler();

        public IngGestion()
        {
            InitializeComponent();
            CargarAreas();
            CargarGrados();
            this.controlador = new UsuarioControler.loginControler();
        }

        private void CargarGrados()
        {
            if (listarGrados == null)
            {
                listarGrados = controladorGradosGrupos.ListarGrados();
            }
            if (listarGrados.Count != 0)
            {
                comboBoxGrado.Items.Clear();
                comboBoxGrado.DataSource = listarGrados;
                comboBoxGrado.DisplayMember = "Grado";
                comboBoxGrado.ValueMember = "idGrado";

            }
            else
            {
                comboBoxGrado.DataSource = null;
                Grupos.DataSource = null;
            }
        }

        private void CargarAreas()
        {
            if (listaAreas == null)
            {
                listaAreas = controladorAreasMateria.ListarAreas();
            }
            if (listaAreas.Count != 0)
            {
                comboArea.Items.Clear();
                comboArea.DataSource = listaAreas;
                comboArea.DisplayMember = "Area";
                comboArea.ValueMember = "idArea";

            }
            else
            {
                comboArea.DataSource = null;
                comboMateria.DataSource = null;
            }
        }

        private void CargarGrupo()
        {
            try
            {

                if (comboBoxGrado.SelectedIndex > 0)
                {
                    int num = int.Parse(comboBoxGrado.SelectedValue.ToString());

                    listarGrupos = controladorGradosGrupos.TraerGruposporGrados(num);

                    if (listarGrupos.Count != 0)
                    {
                        Grupos.DataSource = listarGrupos;


                        Grupos.DisplayMember = "Grupo";
                        Grupos.ValueMember = "idGrupo";
                    }
                }

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("se jodio esto");
            }
        }

        private void CargarMaterias()
        {
            try
            {

                if (comboArea.SelectedIndex > 0)
                {
                    int num = int.Parse(comboArea.SelectedValue.ToString());

                    listaMaterias = controladorAreasMateria.TraerMateriasporArea(num);

                    if (listaMaterias.Count != 0)
                    {
                        comboMateria.DataSource = listaMaterias;


                        comboMateria.DisplayMember = "Materia";
                        comboMateria.ValueMember = "IdMaterias";
                    }
                }

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("se jodio esto");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string grados = comboBoxGrado.Text;
            string grupos = Grupos.Text;
            string areas = comboArea.Text;
            string materias = comboMateria.Text;

            Gestion insertarGestion = new Gestion();
            insertarGestion.grados = grados;
            insertarGestion.grupo = grupos;
            insertarGestion.area = areas;
            insertarGestion.materia = materias;
            
            Respuesta<object> ingreso = this.controlador.insertarGestion(insertarGestion);
            MessageBox.Show("Datos guardados correctamente");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'letrasDataSetGestion.Gestion' Puede moverla o quitarla según sea necesario.
            this.gestionTableAdapter.Fill(this.letrasDataSetGestion.Gestion);
            // TODO: esta línea de código carga datos en la tabla 'letrasDataSetListGestion.Gestion' Puede moverla o quitarla según sea necesario.
            //this.gestionTableAdapter.Fill(this.letrasDataSetListGestion.Gestion);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
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
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MDocente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.pagos.Show();
        }

        private void comboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }


        private void Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrupo();
        }
    }
}

