﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RespuestaLogin
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int perfil { get; set; }
        public string descripcionPerfil { get; set; }
        public string nombre { get; set; }
        public string primerNombre { get; set; }
    }
}
