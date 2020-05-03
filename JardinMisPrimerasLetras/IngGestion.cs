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
        List<Areas> listaAreas = null;
        List<Materias> listaMaterias = null;
        loginControler controladorAreasMateria = new loginControler();

        public IngGestion()
        {
            InitializeComponent();
            CargarAreas();
            this.controlador = new UsuarioControler.loginControler();

            //List<Grupo> response = this.controlador.ObtenerGestion;
            //response.Insert(0, new Gestion() { area = "", grados = "Seleccione" });
            //Grados.DataSource = response;
            //Grados.DisplayMember = "grupo";
            //Grados.ValueMember = "id_grupo";


            //List<Usuario> responseGeation = this.controlador.ObtenerDocentes();
            //comboBox3.DataSource = responseGeation;
            //comboBox3.DisplayMember = "primerNombre";
            //comboBox3.ValueMember = "identificacacion";


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
            string grados = Grados.Text;
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

            //if (textBox1.Text != "A" || textBox1.Text != "B")
            //{
            //    MessageBox.Show("La Division del Grupo debe ser A o B!");
            //}
            //MessageBox.Show("Datos guardados correctamente");

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_Load(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}

