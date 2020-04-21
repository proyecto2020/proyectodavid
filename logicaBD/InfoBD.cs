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
       
        public Collection<RespuestaLogin> ObtenerCredeciales(string usuario, string contraseña)
        {

             DynamicParameters  parameters = new DynamicParameters();
             Collection<RespuestaLogin> objectoR = new Collection<RespuestaLogin>();

             string queryString = $"EXEC " + "PR_ConsultarCredendenciales " +
                contraseña + "," + usuario + " ";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, conexion);
                conexion.Open();
                parameters.Add("@contrasena", contraseña);
                parameters.Add("@usuario", usuario);
                using (var multipleResponse = conexion.QueryMultiple(queryString, parameters))
                {
                    objectoR = new ObservableCollection<RespuestaLogin>(multipleResponse.Read<RespuestaLogin>().ToList());
                }
                if (objectoR.Count > 0)
                {

                    UsuarioLogeadoController.User.Perfil = objectoR[0].descripcionPerfil;
                    UsuarioLogeadoController.User.NombreUsuario = objectoR[0].nombre;
                    UsuarioLogeadoController.User.ApellidoUsuario = objectoR[0].primerNombre;
                
                }

            }
            return objectoR;
          
        }
        public List<Perfiles> ObtenerPerfiles()
        {
            
            string queryString ="select * from perfiles";
            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(queryString);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Perfiles objPerfil = new Perfiles();
                objPerfil.idPerfil = int.Parse(tblRol.Rows[i][0].ToString());
                objPerfil.descripcion = tblRol.Rows[i][1].ToString();
                Perfiles.Add(objPerfil);
            }
            return Perfiles;
        }



        public Respuesta<object> insertarUsuario( Usuario usuario)
        {
            
            DynamicParameters Parameters = new DynamicParameters();
            string storedProcedure = $"EXEC " + "PR_InsertarUsuario ";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                conexion.Open();
                    SqlCommand cmd = new SqlCommand("PR_InsertarUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@pi_Identificacion", usuario.identificacacion);
               cmd.Parameters.AddWithValue("@pi_PrimerNombre", usuario.primerNombre);
               cmd.Parameters.AddWithValue("@pi_SegundoNombre", usuario.segundoNombre);
               cmd.Parameters.AddWithValue("@pi_PrimerApellido", usuario.primerApellido);
               cmd.Parameters.AddWithValue("@pi_SegundoApellido", usuario.segundoApellido);
               cmd.Parameters.AddWithValue("@pi_Correo", usuario.correo);
               cmd.Parameters.AddWithValue("@pi_UsuarioCreacion", usuario.usuarioCreacion);
               cmd.Parameters.AddWithValue("@pi_Perfil", usuario.perfilUsuario);
               cmd.Parameters.AddWithValue("@contraseña", usuario.contrasena);
               cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    throw;
                }
            }
             conexion.Close();
            return respuesta;      
        }

        public List<Usuario> ConsultarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = $"EXEC " + "PR_ConsultarUsuario ";
            SqlCommand command = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.perfilUsuario = Convert.ToInt32(reader["perfilUsuario"].ToString());
                    usuario.primerNombre = reader["primerNombre"].ToString();
                    usuario.primerApellido = reader["primerApellido"].ToString();
                    usuario.segundoApellido = reader["segundoApellido"].ToString();
                    usuario.correo = reader["correo"].ToString();

                    lista.Add(usuario);
                }
            }
            finally
            {
                reader.Close();
            }

            conexion.Close();

            return lista;
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
                SqlCommand cmd = new SqlCommand("PR_InsertarActualizarGradosMateria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idGradosMateria", gestion.idGradosMateria);
                cmd.Parameters.AddWithValue("@idGrados", gestion.grados);
                cmd.Parameters.AddWithValue("@idMateria", gestion.materia);
                cmd.Parameters.AddWithValue("@hora", gestion.horas);
                cmd.Parameters.AddWithValue("@idDocente", gestion.docente);
                cmd.Parameters.AddWithValue("@idDocente", gestion.docente);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }

        public Respuesta<Object> insertarAlumno(Alumnos alumno)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();//DAO Docente solo conexiones y esto para bajo
                SqlCommand cmd = new SqlCommand("InsertarAlumno", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Grados", alumno.nombre);
                cmd.Parameters.AddWithValue("@pi_Grupos", alumno.apellidos);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.fechaNacimiento);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.acudiente);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.correo);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.direccion);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.identificacion);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.ocupacion);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.observacion);
                cmd.Parameters.AddWithValue("@pi_Materia", alumno.telefono);
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
                SqlCommand cmd = new SqlCommand("InsertarAlumno", conexion);
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
