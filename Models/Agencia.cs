using System.ComponentModel.DataAnnotations;

namespace aula4_exercicio.Models
{
    public class Agencia
    {

        [Required]
        [Key]
        public int cgc { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Telefone { get; set; }
    }
}