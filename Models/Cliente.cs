using System.ComponentModel.DataAnnotations;

namespace aula4_exercicio.Models
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Telefone { get; set; }
    }
}