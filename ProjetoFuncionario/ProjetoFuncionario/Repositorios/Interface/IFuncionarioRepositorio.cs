using ProjetoFuncionario.Models;

namespace ProjetoFuncionario.Repositorios.Interface
{
    public interface IFuncionarioRepositorio
    {
        FuncionarioModel Adicionar(FuncionarioModel funcionario);
    }
}
