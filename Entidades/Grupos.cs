using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupos
    {
        int _IdGrupo;
        int _idGrado;
        string _Grupo;


        public int IdGrupo
        {
            get { return _IdGrupo; }
            set { _IdGrupo = value; }
        }

        public int idGrado
        {
            get { return _idGrado; }
            set { _idGrado = value; }
        }

        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        public Grupos(int IdGrupo, int idGrado, string Grupo)
        {
            _IdGrupo = IdGrupo;
            _idGrado = idGrado;
            _Grupo   = Grupo;
        }
        public Grupos() : this(0, 0, "")
        {
        }
    }

}
