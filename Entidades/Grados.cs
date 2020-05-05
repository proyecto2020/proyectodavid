using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grados
    {
        int _idGrado;
        string _Grado;

        public int idGrado
        {
            get { return _idGrado; }
            set { _idGrado = value; }
        }

        public string Grado
        {
            get { return _Grado; }
            set { _Grado = value; }
        }

        public Grados(int idGrado, string Grado)
        {
            _idGrado = idGrado;
            _Grado = Grado;
        }
        public Grados() : this(0, "")
        {
        }
    }
}
