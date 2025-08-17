using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace aula4_exercicio.Models;

public class Cliente
{
    [Required]
    public int Id { get; set; }
    string? CPF { get; set; }
    [Required]
    public string? Nome { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Telefone { get; set; }
    public ICollection<ContaCorrente>? ContasCorrentes { get; set; } // (um cliente pode possuir várias contas //Funciona??

    public void AbrirConta(DbContext context, Agencia agencia) //Testar
    {
        // Lógica para abrir conta
        // context.ContasCorrentes.Add(agencia.CGC); 
        // context.SaveChanges();
    }
}


