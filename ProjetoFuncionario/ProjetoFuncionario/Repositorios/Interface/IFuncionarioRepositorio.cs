using ProjetoFuncionario.Models;
using System.Collections.Generic;

namespace ProjetoFuncionario.Repositorios.Interface
{
    public interface IFuncionarioRepositorio
    {
        List<FuncionarioModel> ListarTodos();

        FuncionarioModel Adicionar(FuncionarioModel funcionario);
    }
}
