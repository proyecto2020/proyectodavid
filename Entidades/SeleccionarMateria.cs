using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SeleccionarMateria
    {
        int _idMateria;
        string _Materia;

        public int idMateria
        {
            get { return _idMateria; }
            set { _idMateria = value; }
        }

        public string Materia
        {
            get { return _Materia; }
            set { _Materia = value; }
        }

        public SeleccionarMateria(int idMateria, string Materia)
        {
            _idMateria = idMateria;
            _Materia = Materia;
        }
        public SeleccionarMateria() : this(0, "")
        {
        }
    }
}
