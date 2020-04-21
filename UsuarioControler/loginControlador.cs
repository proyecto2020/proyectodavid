using Entidades;
using logicaBD;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioControler
{
    public class loginControler : BaseController
    {

        public InfoBD cliente;
        public loginControler()
        {
            this.cliente = new InfoBD();
        }
        public Collection<RespuestaLogin> validarCredenciales(string usuario, string contrasena)
        {

            Collection<RespuestaLogin> retornar = this.cliente.ObtenerCredeciales(usuario, contrasena);
                return retornar;
               
        }
        public List<Perfiles> ObtenerPerfiles()
        {
            List<Perfiles> retornar = this.cliente.ObtenerPerfiles();
            return retornar;
        }


        public Respuesta<object> insertarUsuario(Usuario usuario)
        {
            var resultado = this.cliente.insertarUsuario(usuario);
            return resultado;
        }
        public List<Usuario> ConsultarUsuarios()
        {
            var resultado = this.cliente.ConsultarUsuarios();
            return resultado;
        }

        public List<Perfiles> ConsultarPerfiles()
        {
            var resultado = this.cliente.mtdListarPerfiles();
            return resultado;
        }

        public Respuesta<object> insertarGestion(Gestion gestion)
        {
            var resultado = this.cliente.insertarGestion(gestion);
            return resultado;
        }

        public Respuesta<object> insertarAlumno(Alumnos alumno)
        {
            var resultado = this.cliente.insertarAlumno(alumno);
            return resultado;
        }

        public Respuesta<object> insertarPagos(Pagos pago)
        {
            var resultado = this.cliente.insertarPagos(pago);
            return resultado;
        }

    }
}
