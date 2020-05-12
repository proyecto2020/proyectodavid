using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pagos
    {
        public DateTime fechaPago { get; set; }
        public string nombreApellido { get; set; }
        public double abono { get; set; }
        public double valorAbono { get; set; }
        public double saldoPendiente { get; set; }
        public double totalPagar { get; set; }
        public string observaciones { get; set; }

    }
}
