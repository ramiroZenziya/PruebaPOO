using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EjercicioObjetos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        int Numero = 0;


        private IContador Contador { get; }

        public WeatherForecastController(IContador contador)
        {
            Contador = contador;
        }

        [HttpGet]
        public int Get()
        {
            return Contador.MostrarNumero();
        }
    }
}
