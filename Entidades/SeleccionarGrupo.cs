using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Seleccionar_Grupo
    {
        int _idGrupo;
        string _Grupo;

        public int idAlumnos
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        public Seleccionar_Grupo(int idGrupo, string Grupo)
        {
            _idGrupo = idGrupo;
            _Grupo = Grupo;
        }
        public Seleccionar_Grupo() : this(0, "")
        {
        }
    }
}
