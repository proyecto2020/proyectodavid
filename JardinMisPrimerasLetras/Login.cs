using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Entidades;
namespace JardinMisPrimerasLetras
{
    public partial class Login : Form
    {
        private UsuarioControler.loginControler controlador;
        Matriculas matriculas = new Matriculas();
        Modulo_Notas notas = new Modulo_Notas();
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
            ModPagos pagos = new ModPagos();
            asiganacionAcademica asiganacionacademica = new asiganacionAcademica();
            string usuario = textUsuario.Text;
            string contrasena = textContrasena.Text;
            int perfil = Usuario.perfilUsuario; 
            Collection<RespuestaLogin> ingreso = this.controlador.validarCredenciales(usuario, contrasena, perfil);
            if (ingreso[0].descripcionPerfil =="Secretaria")
            {
                matriculas.Show();
                this.Hide();
            }
            else if (ingreso[0].descripcionPerfil == "Administrador")
            {
                admin.Show();
                this.Hide();
            }
            else if (ingreso[0].descripcionPerfil == "Docente")
            {
                notas.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Las credenciales son incorrectas");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
