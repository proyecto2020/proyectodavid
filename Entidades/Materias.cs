using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materias
    {

        int _IdMaterias;
        int _idArea;
        string _Materia;


        public int IdMaterias
        {
            get { return _IdMaterias; }
            set { _IdMaterias = value; }
        }

        public int idArea
        {
            get { return _idArea; }
            set { _idArea = value; }
        }

        public string Materia
        {
            get { return _Materia; }
            set { _Materia = value; }
        }

        public Materias(int IdMaterias, int idArea, string Materia)
        {
            _IdMaterias = IdMaterias;
            _idArea = idArea;
            _Materia = Materia;
        }
        public Materias() : this(0, 0, "")
        {
        }
    }
}
