using Entidades;
using logicaBD;
using System;
using System.Collections.Generic;
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
        public Respuesta<object> validarCredenciales(string usuario, string contrasena)
        {
           
                var retornar = this.cliente.ObtenerCredeciales(usuario, contrasena);
                return retornar;
               
        }


        public Respuesta<object> insertarUsuario(Usuario usuario)
        {
            var resultado = this.cliente.insertarUsuario(usuario);
            return resultado;
        }

        public Respuesta<object> actualizarUsuario(Usuario usuario)
        {
            var resultado = this.cliente.actualizarUsuario(usuario);
            return resultado;
        }

        public Respuesta<object> eliminarUsuario(Usuario usuario)
        {
            var resultado = this.cliente.eliminarUsuario(usuario);
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
