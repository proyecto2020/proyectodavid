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
        List<Grupos> listarGrupos = null;
        loginControler controladorAlumnos = new loginControler();
        public asiganacionAcademica()
        {
            InitializeComponent();
            CargarAlumnos();
            CargarGrupo();
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
                listarGrupos = controladorAlumnos.ListarGrupos();
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
    }
}
