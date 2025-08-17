using System.ComponentModel.DataAnnotations;


namespace aula4_exercicio.Models;

public class ContaCorrente // ideia: fazer herdar de uma classe Conta
{
    [Required]
    [Key]
    public int Numero { get; set; }

    [Required] public int AgenciaCGC { get; set; } //será chave estrangeira para Agencia
    public Agencia? Agencia { get; set; }

    [Required] public int ClienteId { get; set; } //será chave estrangeira para Cliente
    public Cliente? Cliente { get; set; }
    
    public decimal Saldo { get; private set; } = 0M;



    // public ContaCorrente(int numero, int clienteId, int agenciaCGC, decimal saldoInicial = 0)
    // {
    //     Numero = numero;
    //     ClienteId = clienteId;
    //     AgenciaCGC = agenciaCGC;
    //     Saldo = saldoInicial;
    // }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    public bool Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        return false;
    }
}
