using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Entidades;
namespace JardinMisPrimerasLetras
{
    public partial class Login : Form
    {
        private UsuarioControler.loginControler controlador;
        public Login()
        {
            InitializeComponent();
            this.controlador = new UsuarioControler.loginControler();
        }


        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonSesion_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
            AdministradorUsuarios admin = new AdministradorUsuarios();
            Pagos pagos = new Pagos();
            string usuario = textUsuario.Text;
            string contrasena = textContrasena.Text;
            int perfil = Usuario.perfilUsuario; 
            Collection<RespuestaLogin> ingreso = this.controlador.validarCredenciales(usuario, contrasena, perfil);
            if (Usuario.perfilUsuario.Equals("Administrador"))
            {
                admin.Show();
                this.Hide();
            } else if (Usuario.perfilUsuario.Equals(1))
            {
                pagos.Show();
                this.Hide();
            }

                if (ingreso.Count > 0)
            {

                AdministradorUsuarios usuarios = new AdministradorUsuarios();
                usuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Las credenciales son incorrectas");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
