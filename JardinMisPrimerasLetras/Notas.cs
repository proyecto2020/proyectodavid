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
    public partial class Modulo_Notas : Form
    {
        private UsuarioControler.loginControler controlador;
        List<Alumnos> listarAlumnos = null;
        loginControler controladorAlumnos = new loginControler();
        public Modulo_Notas()
        {
            InitializeComponent();
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            if (listarAlumnos == null)
            {
                listarAlumnos = controladorAlumnos.ListarAlumnos();
            }
            if (listarAlumnos.Count != 0)
            {
                //Estudiante.Items.Clear();
                Estudiante.DataSource = listarAlumnos;
                Estudiante.DisplayMember = "Alumno";
                Estudiante.ValueMember = "idAlumno";

            }
            else
            {
                Estudiante.DataSource = null;
                Estudiante.DataSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string alumno = Estudiante.Text;
            string materia = Materia.Text;
            string periodo = Periodo.Text;
            string calificacion = Calificacion.Text;

            Notas notas = new Notas();
            notas.alumno = alumno;
            notas.materia = materia;
            notas.periodo = periodo;
            notas.calificacion = calificacion;

            Respuesta<object> ingreso = this.controlador.insertarNotas(notas);
            MessageBox.Show("Datos guardados correctamente");
        }
    }
}
