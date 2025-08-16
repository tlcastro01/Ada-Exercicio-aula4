using Microsoft.AspNetCore.Mvc;

//meus imports
using aula4_exercicio.Data;
using aula4_exercicio.Models;
using System;

namespace aula4_exercicio.Controllers
{
    public class AgenciaController : Controller
    {

        private readonly Aula4DbContext _context;

        public AgenciaController(Aula4DbContext context)
        {
            // this._context = context;
            _context = context;
        }


        // Exemplo de método GET
        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Agencias); //retorna o index.cshtml dentro da pasta Views/Agência
        }

        [HttpPost]
        public IActionResult Adicionar(Agencia agencia)
        {
            if (ModelState.IsValid && _context.Agencias.Find(agencia.CGC) == null)
            {
                _context.Agencias.Add(agencia);
                _context.SaveChanges();
            }
            //return View(agencia);
            return RedirectToAction(nameof(Index));
        }


        //[HttpPost]
        public IActionResult Deletar(int cgc)
        {
            var agencia = _context.Agencias.Find(cgc);
            Console.WriteLine($"------------------------------------------ {cgc}");
            if (agencia != null)
            {
                _context.Agencias.Remove(agencia);
                _context.SaveChanges();
                //return RedirectToAction(nameof(Index));
            }
            //return NotFound();
            return RedirectToAction(nameof(Index));
        }


    }
}