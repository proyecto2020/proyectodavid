using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Entidades;
using JardinMisPrimerasLetras.Utilidades.Recursos;

namespace logicaBD
{
    public class InfoBD
    {

        SqlCommand cmdRegistrar;
        SqlDataAdapter adaptador;

        public static string connectionString = ConfigurationManager.ConnectionStrings["JardinMisPrimerasLetras.Properties.Settings.conexionDB"].ToString();
         public SqlConnection conexion  = new  SqlConnection(connectionString);

          private Respuesta<object> respuesta;

        public InfoBD()
        {
            respuesta = new Respuesta<object>();
        }
       
        public Respuesta<object> ObtenerCredeciales(string usuario, string contraseña)
        {

             DynamicParameters  parameters = new DynamicParameters();
             Collection<object> resultados = null;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string queryString = $"EXEC " + "PR_ValidarLogin "  +
                usuario + "," + contraseña + " ";

                conexion.Open();
                parameters.Add("@usuario",usuario);
                parameters.Add("@contraseña",contraseña);
                using (var multipleResponse = conexion.QueryMultiple(queryString, parameters))
                {
                    resultados = new ObservableCollection<object>(multipleResponse.Read<object>().ToList());
                    respuesta.ResultData = resultados;
                }
            }
            return respuesta;
          
        }

      
        public Respuesta<object> insertarUsuario( Usuario usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            DynamicParameters parameters = new DynamicParameters();
            string resultados = null;


            //string StoredProcedure = "PR_InsertarUsuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();//DAO Docente solo conexiones y esto para bajo
                SqlCommand cmd = new SqlCommand("PR_InsertarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Identificacion", usuario.identificacacion);
                cmd.Parameters.AddWithValue("@pi_PrimerNombre", usuario.primerNombre);
                cmd.Parameters.AddWithValue("@pi_SegundoNombre", usuario.segundoNombre);
                cmd.Parameters.AddWithValue("@pi_PrimerApellido", usuario.primerApellido);
                cmd.Parameters.AddWithValue("@pi_SegundoApellido", usuario.segundoApellido);
                cmd.Parameters.AddWithValue("@pi_Correo", usuario.correo);
                cmd.Parameters.AddWithValue("@pi_UsuarioCreacion", usuario.usuario);
                cmd.Parameters.AddWithValue("@pi_Contraseña", usuario.contrasena);
                cmd.Parameters.AddWithValue("@pi_Perfil", usuario.perfilUsuario);
                cmd.Parameters.AddWithValue("@pi_NombreApellido", usuario.nombreApellido);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            
            return respuesta;
            

        }
        

        public Respuesta<object> actualizarUsuario(Usuario usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            DynamicParameters parameters = new DynamicParameters();
            string resultados = null;


            //string StoredProcedure = "PR_ActualizarUsuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();//DAO Docente solo conexiones y esto para bajo
                SqlCommand cmd = new SqlCommand("PR_ActualizarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Identificacion", usuario.identificacacion);
                cmd.Parameters.AddWithValue("@pi_PrimerNombre", usuario.primerNombre);
                cmd.Parameters.AddWithValue("@pi_SegundoNombre", usuario.segundoNombre);
                cmd.Parameters.AddWithValue("@pi_PrimerApellido", usuario.primerApellido);
                cmd.Parameters.AddWithValue("@pi_SegundoApellido", usuario.segundoApellido);
                cmd.Parameters.AddWithValue("@pi_Correo", usuario.correo);
                cmd.Parameters.AddWithValue("@pi_UsuarioCreacion", usuario.usuario);
                cmd.Parameters.AddWithValue("@pi_Contraseña", usuario.contrasena);
                cmd.Parameters.AddWithValue("@pi_Perfil", usuario.perfilUsuario);
                cmd.ExecuteNonQuery();
            }
            return respuesta;

        }

        public Respuesta<object> eliminarUsuario(Usuario usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            DynamicParameters parameters = new DynamicParameters();
            string resultados = null;


            string StoredProcedure = "PR_EliminarUsuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                parameters.Add("@pi_Identificacion", usuario.identificacacion);
                parameters.Add("@pi_PrimerNombre", usuario.primerNombre);
                parameters.Add("@pi_SegundoNombre", usuario.segundoNombre);
                parameters.Add("@pi_PrimerApellido", usuario.primerApellido);
                parameters.Add("@pi_SegundoApellido", usuario.segundoApellido);
                parameters.Add("@pi_Correo", usuario.correo, DbType.String);
                parameters.Add("@pi_UsuarioCreacion", usuario.usuario);
                parameters.Add("@pi_Contraseña", usuario.contrasena);
                parameters.Add("@pi_Perfil", usuario.perfilUsuario);
                int rowAffected = conexion.Execute(StoredProcedure, parameters);
                respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;

        }

        public string insertarGestion(string Docente, string Grupo, string Grado, string Area, string Materia)
        {
            DynamicParameters parameters = new DynamicParameters();
            string resultados = null;

            string queryString = $"EXEC" + " PR_insertar_Usuario " +
              Docente + "," + Grupo + "," + Grado + "," + Area + "," + Materia;
            using (SqlConnection conexión = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(queryString, conexion);
                conexión.Open();
                parameters.Add("@Docente", Docente);
                parameters.Add("@Grupo", Grupo);
                parameters.Add("@Grado", Grado);
                parameters.Add("@Area", Area);
                parameters.Add("@Materia", Materia);
             
                using (var multipleResponse = conexión.QueryMultiple(queryString, parameters))
                {
                    if (resultados == null)
                    {
                        Console.WriteLine("no son valida las credenciales");
                    }
                }
            }
            return resultados;
        }

        List<Perfiles> Perfiles = new List<Perfiles>();

        public List<Perfiles> mtdListarPerfiles()
        {
            string consulta = "select idPerfil,descripcion from Perfiles";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);



            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Perfiles objPerfil = new Perfiles();
                objPerfil.idPerfil = int.Parse(tblRol.Rows[i][0].ToString());
                objPerfil.descripcion = tblRol.Rows[i][1].ToString();
                Perfiles.Add(objPerfil);
            }
            return Perfiles;
        }
        public DataTable mtdSelect(string consulta)
        {

            adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }

        public Respuesta<Object> insertarGestion(Gestion gestion)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();//DAO Docente solo conexiones y esto para bajo
                SqlCommand cmd = new SqlCommand("InsertarGestion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Grados", gestion.grados);
                cmd.Parameters.AddWithValue("@pi_Grupos", gestion.grupo);
                cmd.Parameters.AddWithValue("@pi_Materia", gestion.materia);
                cmd.Parameters.AddWithValue("@pi_Salones", gestion.salones);
                cmd.Parameters.AddWithValue("@pi_Docente", gestion.docente);
                cmd.Parameters.AddWithValue("@pi_Area", gestion.area);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }

        public Respuesta<Object> insertarPagos(Pagos pago)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();//DAO Docente solo conexiones y esto para bajo
                SqlCommand cmd = new SqlCommand("InsertarGestion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Area", pago.abono);
                cmd.Parameters.AddWithValue("@pi_Area", pago.valorAbono);
                cmd.Parameters.AddWithValue("@pi_Area", pago.saldoPendiente);
                cmd.Parameters.AddWithValue("@pi_Area", pago.totalPagar);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }

        public Respuesta<Object> insertarAlumnos(Pagos pago)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();//DAO Docente solo conexiones y esto para bajo
                SqlCommand cmd = new SqlCommand("InsertarGestion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Grados", pago.grupo);
                cmd.Parameters.AddWithValue("@pi_Grupos", pago.grado);
                cmd.Parameters.AddWithValue("@pi_Materia", pago.nombres);
                cmd.Parameters.AddWithValue("@pi_Salones", pago.apellidos);
                cmd.Parameters.AddWithValue("@pi_Docente", pago.fechaNacimiento);
                cmd.Parameters.AddWithValue("@pi_Area", pago.acudiente);
                cmd.Parameters.AddWithValue("@pi_Area", pago.direccion);
                cmd.Parameters.AddWithValue("@pi_Area", pago.cedula);
                cmd.Parameters.AddWithValue("@pi_Area", pago.correo);
                cmd.Parameters.AddWithValue("@pi_Area", pago.telefono);
                cmd.Parameters.AddWithValue("@pi_Area", pago.fechaPago);
                cmd.Parameters.AddWithValue("@pi_Area", pago.observaciones);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }

    }
}
