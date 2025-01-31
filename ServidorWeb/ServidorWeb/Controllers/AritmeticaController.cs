using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServidorWeb.Controllers
{
    public class AritmeticaController : ApiController
    {
        [ActionName("Sumar")]
        [HttpGet]

        public int Sumar(int id)
        {
            int Resultado = id + 10;
            return Resultado;
        }

        [ActionName("Restar")]
        [HttpGet]
        public int Restar(int id)
        {
            int Resultado = id + 10;
            return Resultado;
        }

        [ActionName("Multiplicar")]
        [HttpGet]
        public int Multiplicar(int id)
        {
            int Resultado = id + 10;
            return Resultado;
        }

        [ActionName("Dividir")]
        [HttpGet]
        public int Dividir(int id)
        {
            int Resultado = id + 10;
            return Resultado;
        }
    }
}