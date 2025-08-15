using Microsoft.AspNetCore.Mvc;
using aula4_exercicio.Models;

namespace aula4_exercicio.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class ClienteController : Controller
    {
        // Rota: https://localhost:porta/cliente/Index/id?
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Lista de clientes");
        }

        //Rota: https://localhost:porta/cliente/post/Objeto Cliente
        [HttpPost]
        public IActionResult Post([FromBody] object cliente)
        {
            // Lógica para adicionar cliente
            return Created("", cliente);
        }

        //Rota: https://localhost:porta/cliente/teste/1
        [HttpPost]
        public IActionResult Teste(int id)
        {
            // Lógica para adicionar cliente
            return Created("",id);
        }

    }
}