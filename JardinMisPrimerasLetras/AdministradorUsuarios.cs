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

namespace JardinMisPrimerasLetras
{
    public partial class AdministradorUsuarios : Form
    {
        private UsuarioControler.loginControler controlador;
        IngGestion gestion = new IngGestion();
        public AdministradorUsuarios()
        {
            InitializeComponent();
            this.controlador = new UsuarioControler.loginControler();
                       

            //private void comboTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    List<Perfiles> perfiles = this.controlador.ConsultarPerfiles();
            //    perfiles.Insert(0, new Perfiles() { idPerfil = 0, descripcion = "Seleccione" });
            //    comboTipoPerfil.DataSource = perfiles;
            //    comboTipoPerfil.DisplayMember = "descripcion";
            //    comboTipoPerfil.ValueMember = "idPerfil";
            //}
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string primerNombre = textBox1.Text;
            string segundoNombre = textBox2.Text;
            string identificacacion = textBoxCedula.Text;
            string usuario = textBoxUsuario.Text;
            string primerApellido = textBox3.Text;
            string segundoApellido = textBoxSegundoApellido.Text;
            string correo = textBoxCorreo.Text;
            string contrasena = textBoxContraseña.Text;
            string perfilUsuario = TipoPerfil.Text;
            if (perfilUsuario.Equals("Secretaria"))
            {
                perfilUsuario = "1";
            }
            else if (perfilUsuario.Equals("Docente"))
            {
                perfilUsuario = "2";
            }
            else if (perfilUsuario.Equals("Administrador"))
            {
                perfilUsuario = "3";
            }
            //string nombreApellido = primerNombre + primerApellido;
            string nombreApellido = String.Concat(primerNombre +" " + primerApellido);


            Usuario insertarUsuario = new Usuario();
            insertarUsuario.primerNombre = primerNombre;
            insertarUsuario.segundoNombre = segundoNombre;
            insertarUsuario.primerApellido = primerApellido;
            insertarUsuario.segundoApellido = segundoApellido;
            insertarUsuario.identificacacion = Convert.ToInt32(identificacacion);
            insertarUsuario.usuario = usuario;
            insertarUsuario.correo = correo;
            insertarUsuario.contrasena = contrasena;
            //insertarUsuario.perfilUsuario = perfilUsuario;
            insertarUsuario.perfilUsuario = Convert.ToInt32(perfilUsuario);
            insertarUsuario.nombreApellido = nombreApellido;

            Respuesta<object> ingreso = this.controlador.insertarUsuario(insertarUsuario);

            MessageBox.Show("Datos guardados correctamente");
            
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdministradorUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'perfilesDataSet.Perfiles' Puede moverla o quitarla según sea necesario.
            this.perfilesTableAdapter.Fill(this.perfilesDataSet.Perfiles);
            // TODO: esta línea de código carga datos en la tabla 'jardinDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.jardinDataSet1.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'jardinDataSet.Perfiles' Puede moverla o quitarla según sea necesario.
           // this.perfilesTableAdapter.Fill(this.jardinDataSet.Perfiles);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.gestion.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
