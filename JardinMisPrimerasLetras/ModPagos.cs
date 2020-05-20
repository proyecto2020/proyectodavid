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
        //private UsuarioControler.loginControler controlador;
        loginControler logincontroler = new loginControler();
        //Matriculas matriculas = new Matriculas();
        public ModPagos()
        {
            InitializeComponent();
            //this.logincontroler = new UsuarioControler.loginControler();
            List<Alumnos> response =  this.logincontroler.ListarAlumnos();
            response.Insert(0, new Alumnos() { idAlumno = 0, nombreApellido = "Seleccione" });
            Estudiante.DataSource = response;
            Estudiante.DisplayMember = "nombreApellido";
            Estudiante.ValueMember = "idAlumno";
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
            ingresoPagos.idAlumno = string.Format(Estudiante.SelectedValue.ToString());// Este es el campo para unir la llave foranea, se tiene que modificar el procedimiento almacenado

            Respuesta<object> ingreso = this.logincontroler.insertarPagos(ingresoPagos);
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
           
        }

        private void ModPagos_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Matriculas matriculas = new Matriculas();
            ModPagos pagos = new ModPagos();
            matriculas.Show();
            this.Hide();
        }
    }
}
