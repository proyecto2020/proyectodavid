using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perfiles
    {
        public int idPerfil { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuariocreacion { get; set; }
    }
}
