using System;

using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            List<Perfiles> response = this.controlador.ObtenerPerfiles();
            response.Insert(0, new Perfiles() { idPerfil = 0, descripcion = "Seleccione" });
            TipoPerfil.DataSource = response;
            TipoPerfil.DisplayMember = "descripcion";
            TipoPerfil.ValueMember = "idPerfil";

            List<Usuario> lista = new List<Usuario>();
            lista = this.controlador.ConsultarUsuarios();
            if (lista.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
                this.dataGridView1.Refresh();

            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string primerNombre = textBox1.Text;
            string segundoNombre = textBox2.Text;
            string identificacacion = textBoxCedula.Text;
            string primerApellido = textBox3.Text;
            string segundoApellido = textBoxSegundoApellido.Text;
            string correo = textBoxCorreo.Text;
            int Perfil = int.Parse(TipoPerfil.SelectedValue.ToString());

            string nombreApellido = String.Concat(primerNombre +" " + primerApellido);
            Usuario insertarUsuario = new Usuario();
            insertarUsuario.primerNombre = primerNombre;
            insertarUsuario.segundoNombre = segundoNombre;
            insertarUsuario.primerApellido = primerApellido;
            insertarUsuario.segundoApellido = segundoApellido;
            insertarUsuario.identificacacion = identificacacion;
            insertarUsuario.correo = correo;
            insertarUsuario.perfilUsuario  = Perfil;
            insertarUsuario.nombreApellido = nombreApellido;
            insertarUsuario.usuarioCreacion = "dPrieto";


            Respuesta<object> ingreso = this.controlador.insertarUsuario(insertarUsuario);
            MessageBox.Show("Datos guardados correctamente");

                List<Usuario> lista = new List<Usuario>();
                lista = this.controlador.ConsultarUsuarios();
                if (lista.Count > 0)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = lista;
                    this.dataGridView1.Refresh();

                }
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.gestion.Show();
        }

        private void TipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Usuario> lista = new List<Usuario>();
            lista = this.controlador.ConsultarUsuarios();
            if (lista.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
                this.dataGridView1.Refresh();

            }
        }

        private void AdministradorUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
