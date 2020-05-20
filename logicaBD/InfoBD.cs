﻿using System;
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
       
        public Collection<RespuestaLogin> ObtenerCredeciales(string usuario, string contraseña, int pefil)
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
               cmd.Parameters.AddWithValue("@pi_nombreApellido", usuario.nombreApellido);
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

        List<Usuario> Usuario = new List<Usuario>();
        public List<Usuario> ConsultarUsuario()
        {
            {
                string consulta = "SELECT identificacacion,primerNombre,primerApellido," +
                    "correo, fechaCreacion, perfilUsuario, nombreApellido FROM Usuario";

                DataTable tblRol = new DataTable();
                tblRol = this.mtdSelect(consulta);
                for (int i = 0; i < tblRol.Rows.Count; i++)
                {
                    Usuario objUsuario = new Usuario();
                    objUsuario.identificacacion = int.Parse(tblRol.Rows[i][0].ToString());
                    objUsuario.primerNombre = tblRol.Rows[i][1].ToString();
                    objUsuario.primerApellido = tblRol.Rows[i][2].ToString();
                    objUsuario.correo = tblRol.Rows[i][3].ToString();
                    objUsuario.fechaCreacion = Convert.ToDateTime(tblRol.Rows[i][4].ToString());
                    objUsuario.perfilUsuario = int.Parse(tblRol.Rows[i][5].ToString());
                    objUsuario.nombreApellido = tblRol.Rows[i][6].ToString();
                    Usuario.Add(objUsuario);
                }
                return Usuario;
            }
        }

        List<Usuario> Docente = new List<Usuario>();
        public List<Usuario> ConsultarUsuarios()
        {
            {
                string consulta = "SELECT identificacacion,primerNombre,primerApellido,correo," +
                    " fechaCreacion, perfilUsuario, nombreApellido FROM Usuario where perfilUsuario = 3";

                DataTable tblRol = new DataTable();
                tblRol = this.mtdSelect(consulta);
                for (int i = 0; i < tblRol.Rows.Count; i++)
                {
                    Usuario objUsuario = new Usuario();
                    objUsuario.identificacacion = int.Parse(tblRol.Rows[i][0].ToString());
                    objUsuario.primerNombre = tblRol.Rows[i][1].ToString();
                    objUsuario.primerApellido = tblRol.Rows[i][2].ToString();
                    objUsuario.correo = tblRol.Rows[i][3].ToString();
                    objUsuario.fechaCreacion = Convert.ToDateTime(tblRol.Rows[i][4].ToString());
                    objUsuario.perfilUsuario = int.Parse(tblRol.Rows[i][5].ToString());
                    objUsuario.nombreApellido = tblRol.Rows[i][6].ToString();
                    Docente.Add(objUsuario);
                }
                return Docente;
            }
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

                cmd.Parameters.AddWithValue("@pi_Grados", Convert.ToString(gestion.grados));
                cmd.Parameters.AddWithValue("@pi_Grupos", Convert.ToString(gestion.grupo));
                cmd.Parameters.AddWithValue("@pi_Area", Convert.ToString(gestion.area));
                cmd.Parameters.AddWithValue("@pi_Materia", Convert.ToString(gestion.materia));
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
                SqlCommand cmd = new SqlCommand("PR_insertarAlumno", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi_Identificacion", alumno.identificacion);
                cmd.Parameters.AddWithValue("@pi_PrimerNombre", alumno.nombres);
                cmd.Parameters.AddWithValue("@pi_PrimerApellido", alumno.apellidos);
                cmd.Parameters.AddWithValue("@pi_CorreoAcudiente", alumno.correo);
                cmd.Parameters.AddWithValue("@pi_Acudiente", alumno.acudiente);
                cmd.Parameters.AddWithValue("@pi_Ocupacion", alumno.ocupacion);
                cmd.Parameters.AddWithValue("@pi_Observaciones", alumno.observacion);
                cmd.Parameters.AddWithValue("@pi_Telefono", alumno.telefono);
                cmd.Parameters.AddWithValue("@pi_Direccion", alumno.direccion);
                cmd.Parameters.AddWithValue("@pi_FechaNacimiento", alumno.fechaNacimiento);
                cmd.Parameters.AddWithValue("@pi_NombreApellido", alumno.nombreApellido);
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
                SqlCommand cmd = new SqlCommand("InsertarPagos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Alumno", pago.nombreApellido);
                cmd.Parameters.AddWithValue("@pi_Abono", pago.valorAbono);
                cmd.Parameters.AddWithValue("@pi_Saldo", pago.saldoPendiente);
                cmd.Parameters.AddWithValue("@pi_Total", pago.totalPagar);
                cmd.Parameters.AddWithValue("@pi_Observaciones", pago.observaciones);
                cmd.Parameters.AddWithValue("@pi_idAlumno", pago.idAlumno);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }



        public List<Grados> ListarGrados()
        {
            List<Grados> listaGrados = new List<Grados>();

            Grados a = new Grados(0, "Seleccionar");
            listaGrados.Add(a);

            //Metodo que carga en una lista el resultado de todos los registros de la tabla

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("TraerGradoGrupo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", 1);
                cmd.Parameters.AddWithValue("@ID_Grado", 0);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        a = new Grados((int)dr["idGrado"],
                            (string)dr["descripcion"]);
                        listaGrados.Add(a);
                    }
                }
            }
            return listaGrados;
        }

        public List<Grupos> TraerGruposporGrados(int Id)
        {
            List<Grupos> traerGruposporGrados = new List<Grupos>();

            Grupos a = new Grupos(0, 0, "Seleccionar");
            traerGruposporGrados.Add(a);

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("TraerGradoGrupo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", 2);
                cmd.Parameters.AddWithValue("@ID_Grado", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        a = new Grupos((int)dr["idGrado"],
                            (int)dr["idGrado"],
                            (string)dr["descripcion"]);
                        traerGruposporGrados.Add(a);
                    }
                }
            }
            return traerGruposporGrados;
        }

        public List<Areas> ListarAreas()
        {
            List<Areas> listaAreas = new List<Areas>();

            Areas a = new Areas(0,"Seleccionar");
            listaAreas.Add(a);

            //Metodo que carga en una lista el resultado de todos los registros de la tabla

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("TraerAreaMateria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", 1);
                cmd.Parameters.AddWithValue("@ID_Area", 0);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        a = new Areas((int)dr["idArea"],
                            (string)dr["descripcion"]);
                        listaAreas.Add(a);
                    }
                }
            }
            return listaAreas;
        }

        public List<Materias> TraerMateriasporArea(int Id)
        {
            List<Materias> listaMaterias = new List<Materias>();

            Materias a = new Materias(0, 0, "Seleccionar");
            listaMaterias.Add(a);

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("TraerAreaMateria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", 2);
                cmd.Parameters.AddWithValue("@ID_Area", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        a = new Materias((int)dr["idMateria"],
                            (int)dr["idArea"],
                            (string)dr["descripcion"]);
                        listaMaterias.Add(a);
                    }
                }
            }
            return listaMaterias;
        }

        List<Alumnos> Alumnos = new  List<Alumnos>();
        public List<Alumnos> ListarAlumnos()
        {
            string consulta = "select idAlumno,nombreApellido from Alumno";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Alumnos objPerfil = new Alumnos();
                objPerfil.idAlumno = int.Parse(tblRol.Rows[i][0].ToString());
                objPerfil.nombreApellido = tblRol.Rows[i][1].ToString();
                Alumnos.Add(objPerfil);
            }
            return Alumnos;
        }

        List<Seleccionar_Grupo> listaGrupos = new List<Seleccionar_Grupo>();
        public List<Seleccionar_Grupo> ListarGrupos()
        {
            string consulta = "select idGrupoEscolar, descripcion from GrupoEscolar";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                Seleccionar_Grupo objgrupo = new Seleccionar_Grupo();
                objgrupo.idGrupo = int.Parse(tblRol.Rows[i][0].ToString());
                objgrupo.Grupo = tblRol.Rows[i][1].ToString();
                listaGrupos.Add(objgrupo);
            }
            return listaGrupos;
        }

        List<SeleccionarMateria> listaMateria = new List<SeleccionarMateria>();
        public List<SeleccionarMateria> ListarMaterias()
        {
            string consulta = "select idMateria, descripcion from Materias";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                SeleccionarMateria objMateria = new SeleccionarMateria();
                objMateria.idMateria = int.Parse(tblRol.Rows[i][0].ToString());
                objMateria.Materia = tblRol.Rows[i][1].ToString();
                listaMateria.Add(objMateria);
            }
            return listaMateria;
        }

        List<SeleccionarSalon> listaSalon = new List<SeleccionarSalon>();
        public List<SeleccionarSalon> ListarSalon()
        {
            string consulta = "select idSalon, descripcion from Salon";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                SeleccionarSalon objSalon = new SeleccionarSalon();
                objSalon.idSalon = int.Parse(tblRol.Rows[i][0].ToString());
                objSalon.Salon = tblRol.Rows[i][1].ToString();
                listaSalon.Add(objSalon);
            }
            return listaSalon;
        }

        List<SeleccionarHora> listaHora = new List<SeleccionarHora>();
        public List<SeleccionarHora> ListarHora()
        {
            string consulta = "select idHora, descripcion from Hora";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                SeleccionarHora objHora = new SeleccionarHora();
                objHora.idHora = int.Parse(tblRol.Rows[i][0].ToString());
                objHora.Hora = tblRol.Rows[i][1].ToString();
                listaHora.Add(objHora);
            }
            return listaHora;
        }

        List<SeleccionarDia> listaDia = new List<SeleccionarDia>();
        public List<SeleccionarDia> ListarDia()
        {
            string consulta = "select idDia, descripcion from Dia";

            DataTable tblRol = new DataTable();
            tblRol = this.mtdSelect(consulta);
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                SeleccionarDia objDia = new SeleccionarDia();
                objDia.idDia = int.Parse(tblRol.Rows[i][0].ToString());
                objDia.Dia = tblRol.Rows[i][1].ToString();
                listaDia.Add(objDia);
            }
            return listaDia;
        }

        public Respuesta<Object> insertarAsignacion(AsignacionAcademica asignacionAcademica)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("PR_InsertarAsignacion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Grupo", asignacionAcademica.grupo);
                cmd.Parameters.AddWithValue("@pi_Materia", asignacionAcademica.materia);
                cmd.Parameters.AddWithValue("@pi_Salon", asignacionAcademica.salon);
                cmd.Parameters.AddWithValue("@pi_Dia", asignacionAcademica.dia);
                cmd.Parameters.AddWithValue("@pi_Hora", asignacionAcademica.hora);
                cmd.Parameters.AddWithValue("@pi_Docente", asignacionAcademica.docente);
                cmd.Parameters.AddWithValue("@pi_Observaciones", asignacionAcademica.observaciones);
                cmd.Parameters.AddWithValue("@pi_idDocente", asignacionAcademica.idDocente);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }

        public Respuesta<Object> insertarNotas(Notas notas)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("PR_InsertarNotas", conexion); // Crear procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pi_Alumno", notas.alumno);
                cmd.Parameters.AddWithValue("@pi_Materia", notas.materia);
                cmd.Parameters.AddWithValue("@pi_Periodo", notas.periodo);
                cmd.Parameters.AddWithValue("@pi_Calificacion", notas.calificacion);
                cmd.Parameters.AddWithValue("@pi_idAlumno", notas.idAlumno);
                cmd.ExecuteNonQuery();

                //respuesta.ResultData = new ObservableCollection<object>(new List<object> { rowAffected });
            }
            return respuesta;
        }

    }
}
