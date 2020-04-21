using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pagos
    {
        public string grupo { get; set; }
        public string grado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string acudiente { get; set; }
        public string direccion { get; set; }
        public int cedula { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public DateTime fechaPago { get; set; }
        public int abono { get; set; }
        public int valorAbono { get; set; }
        public int saldoPendiente { get; set; }
        public int totalPagar { get; set; }
        public string observaciones { get; set; }

    }
}
