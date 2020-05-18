using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using UsuarioControler;

namespace JardinMisPrimerasLetras
{
    public partial class asiganacionAcademica : Form
    {
        loginControler logincontroller = new loginControler();
        
        //loginUsuarioControler usuarioControler = new UsuarioControler();
        public asiganacionAcademica()
        {
            InitializeComponent();

            //List<Alumnos> response = this.logincontroller.ListarAlumnos();
            //response.Insert(0, new Alumnos() { idAlumno = 0, nombreApellido = "Seleccione" });
            //Estudiante.DataSource = response;
            //Estudiante.DisplayMember = "nombreApellido";
            //Estudiante.ValueMember = "idAlumno";

            List<Usuario> usuario = this.logincontroller.ConsultarUsuarios();
            usuario.Insert(0, new Usuario() { identificacacion = 0, nombreApellido = "Seleccione" });
            Docente.DataSource = usuario;
            Docente.DisplayMember = "nombreApellido";
            Docente.ValueMember = "identificacacion";
            this.Docente.Refresh();

            List<Seleccionar_Grupo> listarGrupo = this.logincontroller.ListarGrupos();
            listarGrupo.Insert(0, new Seleccionar_Grupo() { idGrupo = 0, Grupo = "Seleccione" });
            Grupo.DataSource = listarGrupo;
            Grupo.DisplayMember = "Grupo";
            Grupo.ValueMember = "idGrupo";

            List<SeleccionarMateria> listarMaterias = this.logincontroller.ListarMaterias();
            listarMaterias.Insert(0, new SeleccionarMateria() { idMateria = 0, Materia = "Seleccione" });
            Materia.DataSource = listarMaterias;
            Materia.DisplayMember = "Materia";
            Materia.ValueMember = "idMateria";

            List<SeleccionarSalon> listarSalon = this.logincontroller.ListarSalon();
            listarSalon.Insert(0, new SeleccionarSalon() { idSalon = 0, Salon = "Seleccione" });
            Salon.DataSource = listarSalon;
            Salon.DisplayMember = "Salon";
            Salon.ValueMember = "idSalon";

            List<SeleccionarDia> listarDia = this.logincontroller.ListarDia();
            listarDia.Insert(0, new SeleccionarDia() { idDia = 0, Dia = "Seleccione" });
            Dia.DataSource = listarDia;
            Dia.DisplayMember = "Dia";
            Dia.ValueMember = "idDia";

            List<SeleccionarHora> listarHora = this.logincontroller.ListarHora();
            listarHora.Insert(0, new SeleccionarHora() { idHora = 0, Hora = "Seleccione" });
            Hora.DataSource = listarHora;
            Hora.DisplayMember = "Hora";
            Hora.ValueMember = "idHora";
        }
        
        private void asiganacionAcademica_Load(object sender, EventArgs e)
        {
            
        }

        private void Estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Materia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //string alumno = Estudiante.Text;
            string grupo = Grupo.Text;
            string materia = Materia.Text;
            string salon = Salon.Text;
            string dia = Dia.Text;
            string hora = Hora.Text;
            string docente = Docente.Text;
            string observaciones = Observaciones.Text;

            AsignacionAcademica asignacionAcademica = new AsignacionAcademica();
            //asignacionAcademica.alumno = alumno;
            asignacionAcademica.grupo = grupo;
            asignacionAcademica.materia = materia;
            asignacionAcademica.salon = salon;
            asignacionAcademica.dia = dia;
            asignacionAcademica.hora = hora;
            asignacionAcademica.docente = docente;
            asignacionAcademica.observaciones = observaciones;

            Respuesta<object> ingreso = this.logincontroller.insertarAsignacion(asignacionAcademica);
            MessageBox.Show("Datos guardados correctamente");
            
            
        }

        private void Docente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Docente.Refresh();
        }

        private void Salon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
