using aula4_exercicio.Models;
using Microsoft.EntityFrameworkCore;

namespace aula4_exercicio.Data
{
    public class Aula4DbContext : DbContext
    {
        public DbSet<Cliente> Clientes => Set<Cliente>(); // criando tabela do banco de dados com 
                                                          // EntityFramework
        public DbSet<Agencia> Agencias => Set<Agencia>();

        public Aula4DbContext(DbContextOptions<Aula4DbContext> options)
            : base(options)
        {
        }

    }
}