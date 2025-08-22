using Microsoft.AspNetCore.Mvc;
using MiPirmeraApi.Models;

namespace MiPirmeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroControllers : ControllerBase

    {
        private static List<Carro> Carros = new()
        {
            new Carro{Color = "Azul", Placa = "TX15"},
            new Carro{Color = "Rojo", Placa = "TX15"}
        };


        [HttpGet]
        [Route("GetCarro")]
        public IEnumerable<Carro>  GetCarros()
        {
            return Carros;
        }

        [HttpPost]
        [Route("CreateCarro")]
        
        public ActionResult <Carro> CreateCarro (Carro carro)
        {
            Carros.Add(carro);
            return carro;
        }

    } 
}
