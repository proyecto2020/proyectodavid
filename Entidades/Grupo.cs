﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        public int id_grupo { get; set; }
        /// <summary>
        /// Grupo.
        /// </summary>
        public string grupo { get; set; }
        /// <summary>
        /// FechaCreacion.
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// FechaModificación.
        /// </summary>
        public DateTime FechaModificación { get; set; }
        /// <summary>
        /// Usuario.
        /// </summary>
        public int Usuario { get; set; }

        /// <summary>
        /// Grado.
        /// </summary>
        public int Grado { get; set; }

        public string NombreGrado { get; set; }
    }
}
