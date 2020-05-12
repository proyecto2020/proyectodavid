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
    public partial class ModPagos : Form
    {
        private UsuarioControler.loginControler controlador;
        List<Alumnos> listarAlumnos = null;
        loginControler controladorAlumnos = new loginControler();
        public ModPagos()
        {
            InitializeComponent();
            CargarAlumnos();
            this.controlador = new UsuarioControler.loginControler();
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

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'letrasDataSetAlum.Alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.letrasDataSetAlum.Alumno);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombres_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombreApellido = Estudiante.Text;
            string abono = ValorAbono.Text;
            //string pendiente = Saldo.Text;
            string total = Total.Text;
            string observaciones = Observaciones.Text;

            Pagos ingresoPagos = new Pagos();
            ingresoPagos.nombreApellido = nombreApellido;
            ingresoPagos.valorAbono = Convert.ToDouble(abono);
            ingresoPagos.totalPagar = Convert.ToDouble(total);
            ingresoPagos.saldoPendiente = (Convert.ToDouble(abono) - Convert.ToDouble(total));
            ingresoPagos.observaciones = observaciones;

            Respuesta<object> ingreso = this.controlador.insertarPagos(ingresoPagos);
            MessageBox.Show("Datos guardados correctamente, su saldo es: " + ingresoPagos.saldoPendiente + ".");

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Saldo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
    }
}
