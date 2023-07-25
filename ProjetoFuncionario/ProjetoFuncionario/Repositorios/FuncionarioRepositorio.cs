using ProjetoFuncionario.Data;
using ProjetoFuncionario.Models;
using ProjetoFuncionario.Repositorios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFuncionario.Repositorios
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BancoContext _context;

        public FuncionarioRepositorio(BancoContext context)
        {
            this._context = context;
        }

        public List<FuncionarioModel> ListarTodos()
        {
            return _context.Funcionarios.ToList();
        }
        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
            return funcionario;
        }

        public FuncionarioModel ListarPorId(int id)
        {
            return _context.Funcionarios.FirstOrDefault(x => x.Id == id);
        }

        public FuncionarioModel Atualizar(FuncionarioModel funcionario)
        {
            FuncionarioModel funcionariodb = ListarPorId(funcionario.Id);

            if (funcionariodb == null) throw new Exception("Houve um erro na atualização do funcionario");

            funcionariodb.Nome = funcionario.Nome;
            funcionariodb.Email = funcionario.Email;
            funcionariodb.Profissao = funcionario.Profissao;
            funcionariodb.TempoExperiencia = funcionario.TempoExperiencia;
            funcionariodb.Salario = funcionario.Salario;

            _context.Funcionarios.Update(funcionariodb);
            _context.SaveChanges();

            return funcionariodb;
        }

        public bool Apagar(int id)
        {
            FuncionarioModel funcionariodb = ListarPorId(id);

            if(funcionariodb == null) throw new Exception("Houve um erro na deleção do funcionario");

            _context.Funcionarios.Remove(funcionariodb);
            _context.SaveChanges();

            return true;


        }
    }
}
