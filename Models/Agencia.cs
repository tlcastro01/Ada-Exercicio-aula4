using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aula4_exercicio.Models;

public class Agencia
{

    [Required]
    [Key]
    public int CGC { get; set; }
    [Required]
    public string? Nome { get; set; }
    [Required]
    public string? Endereco { get; set; }
    [Required]
    public string? Telefone { get; set; }

    public ICollection<ContaCorrente>? ContasCorrentes { get; set; } // (uma agência possui várias contas) //Funciona?? O Entity Framework interpreta isso como uma relação um-para-muitos?
}
