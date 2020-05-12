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
    public partial class asiganacionAcademica : Form
    {
        private UsuarioControler.loginControler controlador;
        List<Alumnos> listarAlumnos = null;
        //List<Grupos> listarGrupos = null;
        List<Seleccionar_Grupo> listarGrupos = null;
        List<SeleccionarMateria> listarMaterias = null;

        loginControler controladorAlumnos = new loginControler();
        loginControler seleccionargrupo = new loginControler();
        loginControler seleccionarmateria = new loginControler();
        public asiganacionAcademica()
        {
            InitializeComponent();
            CargarAlumnos();
            CargarGrupo();
            CargarMateria();
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

        private void CargarGrupo()
        {
            if (listarGrupos == null)
            {
                listarGrupos = seleccionargrupo.ListarGrupos();
            }
            if (listarAlumnos.Count != 0)
            {
                //Estudiante.Items.Clear();
                Grupo.DataSource = listarGrupos;
                Grupo.DisplayMember = "Grupo";
                Grupo.ValueMember = "idGrupo";

            }
            else
            {
                Grupo.DataSource = null;
                Grupo.DataSource = null;
            }
        }

        private void CargarMateria()
        {
            if (listarMaterias == null)
            {
                listarMaterias = seleccionarmateria.ListarMaterias();
            }
            if (listarMaterias.Count != 0)
            {
                //Estudiante.Items.Clear();
                Estudiante.DataSource = listarMaterias;
                Estudiante.DisplayMember = "Materia";
                Estudiante.ValueMember = "idMateria";

            }
            else
            {
                Estudiante.DataSource = null;
                Estudiante.DataSource = null;
            }
        }

        private void asiganacionAcademica_Load(object sender, EventArgs e)
        {

        }

        private void Estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrupo();
        }

        private void Materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMateria();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string grupo = Grupo.Text;
            string materia = Materia.Text;
            string salon = Salon.Text;
            string dia = Dia.Text;
            string hora = Hora.Text;
            string docente = Docente.Text;
            string observaciones = Observaciones.Text;

            AsignacionAcademica ingresarAsignacion = new AsignacionAcademica();
            ingresarAsignacion.grupo = grupo;
            ingresarAsignacion.materia = materia;
            ingresarAsignacion.salon = salon;
            ingresarAsignacion.dia = dia;
            ingresarAsignacion.hora = hora;
            ingresarAsignacion.docente = docente;
            ingresarAsignacion.observaciones = observaciones;

            Respuesta<object> ingreso = this.controlador.insertarAsignacion(ingresarAsignacion);
            MessageBox.Show("Datos guardados correctamente");
        }
    }
}
