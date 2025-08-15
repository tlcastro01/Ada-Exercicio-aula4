using Microsoft.AspNetCore.Mvc;

namespace aula4_exercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgenciaController : Controller
    {
        // Exemplo de método GET
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("AgênciaController está funcionando.");
            //return View(); //retorna o index.cshtml dentro da pasta Views/Agência
        }
    }
}