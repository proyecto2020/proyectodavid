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
            int calificacion = int.Parse(Calificacion.Text);
            if (calificacion < 6)
            {
                calificacion = Convert.ToInt32("Insuficiente");
            } 
            else if (calificacion > 5 && calificacion < 8 )
            {
                calificacion = Convert.ToInt32("Aceptable");
            }
            else if (calificacion > 7 && calificacion < 9)
            {
                calificacion = Convert.ToInt32("Sobresaliente");
            }
            else if (calificacion > 8 && calificacion <= 10)
            {
                calificacion = Convert.ToInt32("Excelente");
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
