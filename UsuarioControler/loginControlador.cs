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
        public Collection<RespuestaLogin> validarCredenciales(string usuario, string contrasena, int perfil)
        {

            Collection<RespuestaLogin> retornar = this.cliente.ObtenerCredeciales(usuario, contrasena);
            return retornar;

        }

        public List<Gestion> ObtenerGestion()
        {

            throw new NotImplementedException();
        }

        public List<Perfiles> ObtenerPerfiles()
        {
            List<Perfiles> retornar = this.cliente.ObtenerPerfiles();
            return retornar;
        }

        public List<Usuario> ObtenerDocentes()
        {
            throw new NotImplementedException();
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

        public Respuesta<object> insertarAlumno(Alumnos insertarAlumno)
        {
            var resultado = this.cliente.insertarAlumno(insertarAlumno);
            return resultado;
        }

        public Respuesta<object> insertarPagos(Pagos pago)
        {
            var resultado = this.cliente.insertarPagos(pago);
            return resultado;
        }

        public List<Grados> ListarGrados()
        {
            var resultado = this.cliente.ListarGrados();
            return resultado;
        }

        public List<Grupos> TraerGruposporGrados(int Id)
        {
            var resultado = this.cliente.TraerGruposporGrados(Id);
            return resultado;
        }

        public List<Areas> ListarAreas()
        {
            var resultado = this.cliente.ListarAreas();
            return resultado;
        }

        public List<Materias> TraerMateriasporArea(int Id)
        {
            var resultado = this.cliente.TraerMateriasporArea(Id);
            return resultado;
        }

        public List<Alumnos> ListarAlumnos()
        {
            var resultado = this.cliente.ListarAlumnos();
            return resultado;
        }

        public List<Seleccionar_Grupo> ListarGrupos()
        {
            var resultado = this.cliente.ListarGrupos();
            return resultado;
        }

        public List<SeleccionarMateria> ListarMaterias()
        {
            var resultado = this.cliente.ListarMaterias();
            return resultado;
        }

        public Respuesta<object> insertarAsignacion(AsignacionAcademica asignacionAcademica)
        {
            var resultado = this.cliente.insertarAsignacion(asignacionAcademica);
            return resultado;
        }

    }
}
