using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

//meus imports
using aula4_exercicio.Data;
using aula4_exercicio.Models;

//using System;
//using System.Data.Common;

namespace aula4_exercicio.Controllers;

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
        if (agencia != null)
        {
            _context.Agencias.Remove(agencia);
            _context.SaveChanges();
            //return RedirectToAction(nameof(Index));
        }
        //return NotFound();
        return RedirectToAction(nameof(Index));
    }



    [HttpGet]
    public IActionResult Editar(int CGC)
    {
        //faço depois
        var agencia = _context.Agencias.Find(CGC);
        if (agencia != null)
        {

            return View(agencia);
        }
        return NotFound();
    }

    [HttpPost]
    public IActionResult Editar(Agencia agencia)
    {
        _context.Agencias.Update(agencia);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult ListarContas(int cgc)
    {
        List<ContaCorrente> contas = _context.ContasCorrentes.FromSqlRaw("SELECT * FROM ContasCorrentes WHERE AgenciaCGC = {0}", cgc).ToList();
        return View(contas);
    }
}