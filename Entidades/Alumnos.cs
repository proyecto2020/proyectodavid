﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumnos
    {
        public int idAlumno { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string fechaNacimiento { get; set; }
        public string acudiente { get; set; }
        public string direccion { get; set; }
        public string identificacion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string ocupacion { get; set; }
        public string observacion { get; set; }
        public string insertarAlumno { get; set; }
        public string nombreApellido { get; set; }

        int _idAlumno;
        string _Alumno;

        public int idAlumnos
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        public string Alumno
        {
            get { return _Alumno; }
            set { _Alumno = value; }
        }

        public Alumnos(int idAlumno, string Alumno)
        {
            _idAlumno = idAlumno;
            _Alumno = Alumno;
        }
        public Alumnos() : this(0, "")
        {
        }
    }
}
