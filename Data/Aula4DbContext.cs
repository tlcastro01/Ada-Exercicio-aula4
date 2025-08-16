using aula4_exercicio.Models;
using Microsoft.EntityFrameworkCore;

namespace aula4_exercicio.Data
{
    public class Aula4DbContext : DbContext
    {
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Agencia> Agencias => Set<Agencia>();
        public DbSet<ContaCorrente> ContasCorrentes => Set<ContaCorrente>();

        public Aula4DbContext(DbContextOptions<Aula4DbContext> options) : base(options)
        {
        }



    }
}