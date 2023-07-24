using ProjetoFuncionario.Data;
using ProjetoFuncionario.Models;
using ProjetoFuncionario.Repositorios.Interface;

namespace ProjetoFuncionario.Repositorios
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BancoContext _context;

        public FuncionarioRepositorio(BancoContext context)
        {
            this._context = context;
        }

        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
            return funcionario;
        }
    }
}
