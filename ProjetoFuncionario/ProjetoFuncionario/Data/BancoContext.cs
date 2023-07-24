using Microsoft.EntityFrameworkCore;
using ProjetoFuncionario.Models;

namespace ProjetoFuncionario.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
