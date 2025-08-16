using Microsoft.AspNetCore.Mvc;
using aula4_exercicio.Models;
using aula4_exercicio.Data;


namespace aula4_exercicio.Controllers
{


    public class ContaCorrenteController : Controller
    {
        private readonly Aula4DbContext _context;

        public ContaCorrenteController(Aula4DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.ContasCorrentes);
        }

        [HttpPost]
        public IActionResult AbrirConta(ContaCorrente contaCorrente)
        {

            var agencia = _context.Agencias.Find(contaCorrente.AgenciaCGC);
            var cliente = _context.Clientes.Find(contaCorrente.ClienteId);

            // Verifica se a conta já existe
            if (!ModelState.IsValid || cliente == null || agencia == null)
            {
                return RedirectToAction(nameof(Index));
            }


            //_context.Clientes.Add(cliente);
            //_context.SaveChanges();
            _context.ContasCorrentes.Add(contaCorrente);
            _context.SaveChanges();
            //cliente.AbrirConta(_context, agencia);

            return RedirectToAction(nameof(Index)); //Funciona??
            //return Ok("Conta adicionada com sucesso!"); // Retorna uma mensagem de sucesso

        }

        [HttpPost]
        public IActionResult Deletar(int numero)
        {
            var contaCorrente = _context.ContasCorrentes.Find(numero);
            if (contaCorrente != null)
            {
                _context.ContasCorrentes.Remove(contaCorrente);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Editar(ContaCorrente contaCorrente)
        {
            //faço depois
            return Ok("");
        }

    }
}