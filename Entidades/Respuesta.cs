namespace Entidades
{
    using System.Collections.Generic;
    using System.Net;

    public class Respuesta<T> where T : class
    {
        public IList<T> ResultData { get; set; }

        public int FilasAfectada { get; set; }

        public HttpStatusCode ResultTransaccion { get; set; }

        public List<string> Erros { get; set; }
    }
}
