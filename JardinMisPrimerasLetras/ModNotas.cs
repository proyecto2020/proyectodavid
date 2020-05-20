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
        
        loginControler logincontroller = new loginControler();
        public Modulo_Notas()
        {
            InitializeComponent();
            //this.logincontroler = new UsuarioControler.loginControler();
            List<Alumnos> response = this.logincontroller.ListarAlumnos();
            response.Insert(0, new Alumnos() { idAlumno = 0, nombreApellido = "Seleccione" });
            Estudiante.DataSource = response;
            Estudiante.DisplayMember = "nombreApellido";
            Estudiante.ValueMember = "idAlumno";

            List<SeleccionarMateria> listarMaterias = this.logincontroller.ListarMaterias();
            listarMaterias.Insert(0, new SeleccionarMateria() { idMateria = 0, Materia = "Seleccione" });
            Materia.DataSource = listarMaterias;
            Materia.DisplayMember = "Materia";
            Materia.ValueMember = "idMateria";
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
            if (int.Parse(Calificacion.Text) < 6)
            {
                calificacion = "Insuficiente";
            }
            else if (int.Parse(Calificacion.Text) > 5 && int.Parse(Calificacion.Text) < 8)
            {
                calificacion = "Aceptable";
            }
            else if (int.Parse(Calificacion.Text) > 7 && int.Parse(Calificacion.Text) < 9)
            {
                calificacion = "Sobresaliente";
            }
            else if (int.Parse(Calificacion.Text) > 8 && int.Parse(Calificacion.Text) <= 10)
            {
                calificacion = "Excelente";
            }
            else if((int.Parse(Calificacion.Text) > 10))
            {
                MessageBox.Show("No se puede ingresar una nota mayor de 10.");
            }

            Notas notas = new Notas();
            notas.alumno = alumno;
            notas.materia = materia;
            notas.periodo = periodo;
            notas.calificacion = calificacion;
            notas.idAlumno = string.Format(Estudiante.SelectedValue.ToString());

            Respuesta<object> ingreso = this.logincontroller.insertarNotas(notas);
            MessageBox.Show("Datos guardados correctamente");
        }

        private void Modulo_Notas_Load(object sender, EventArgs e)
        {

        }
    }
}
