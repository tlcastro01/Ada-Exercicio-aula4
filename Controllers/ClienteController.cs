using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

//meus imports
using aula4_exercicio.Models;
using aula4_exercicio.Data;


namespace aula4_exercicio.Controllers;

//[ApiController]
//[Route("[controller]")]
public class ClienteController : Controller
{

    private readonly Aula4DbContext _context;
    public ClienteController(Aula4DbContext context)
    {
        _context = context; //Inserindo banco de dados no controller
    }

    // Rota: https://localhost:porta/cliente/Index/id?
    [HttpGet]
    public IActionResult Index()
    {
        //return Ok("Lista de clientes");
        return View(_context.Clientes); // Retorna o index.cshtml dentro da pasta Views/Cliente
    }

    [HttpPost]
    public IActionResult Adicionar(Cliente cliente)
    {
        if (ModelState.IsValid && _context.Clientes.Find(cliente.Id) == null)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        //return View(cliente);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Deletar(int id)
    {
        var cliente = _context.Clientes.Find(id);
        if (cliente != null)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }

    // //Rota: https://localhost:porta/cliente/post/Objeto Cliente
    // [HttpPost]
    // public IActionResult Post([FromBody] object cliente)
    // {
    //     // Lógica para adicionar cliente
    //     return Created("", cliente);
    // }

    // //Rota: https://localhost:porta/cliente/teste/1
    // [HttpPost]
    // public IActionResult Teste(int id)
    // {
    //     // Lógica para adicionar cliente
    //     return Created("",id);
    // }

    [HttpGet]
    public IActionResult Editar(int id)
    {
        //faço depois
        var cliente = _context.Clientes.Find(id);
        if (cliente != null)
        {

            return View(cliente);
        }
        return NotFound();
    }

    [HttpPost]
    public IActionResult Editar(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult ListarContas(int id)
    {
        List<ContaCorrente> contas = _context.ContasCorrentes.FromSqlRaw("SELECT * FROM ContasCorrentes WHERE ClienteId = {0}", id).ToList();
        return View(contas);
    }

}
