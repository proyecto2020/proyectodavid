using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioControler
{
    public class BaseController
    {
        

        public Respuesta<T> RespuestaOK<T>(IList<T> data, int rowAffects = 0) where T : class
        {
            return new Respuesta<T>
            {
                FilasAfectada = rowAffects,
                ResultData = data,
                Erros = new List<string>(),
                ResultTransaccion = HttpStatusCode.OK
            };
        }

        public Respuesta<T> RespuestaError<T>(List<string> errors) where T : class
        {
            return new Respuesta<T>
            {
                FilasAfectada = default(int),
                ResultData = new List<T>(),
                Erros = errors,
                ResultTransaccion = HttpStatusCode.BadRequest
            };
        }
    }
}
