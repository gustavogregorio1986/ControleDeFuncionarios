using Microsoft.AspNetCore.Mvc;
using ProjetoFuncionario.Models;
using ProjetoFuncionario.Repositorios.Interface;
using System.Collections.Generic;

namespace ProjetoFuncionario.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            this._funcionarioRepositorio = funcionarioRepositorio;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FuncionarioModel funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _funcionarioRepositorio.Adicionar(funcionario);
                    TempData["MensagemSucesso"] = "Contato Cadastrado com sucesso";
                    return RedirectToAction("Cadastrar");
                }

                return View(funcionario);
            }
            catch (System.Exception erro)
            {
                _funcionarioRepositorio.Adicionar(funcionario);
                TempData["MensagemSucesso"] = $"Ops, não conseguimos cadastrar seu funcionario, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Cadastrar");
            }
        }

        [HttpGet]
        public IActionResult Consultar()
        {
            List<FuncionarioModel> listar = _funcionarioRepositorio.ListarTodos();
            return View(listar);
        }


        public IActionResult Editar(int id)
        {
            FuncionarioModel funcionario = _funcionarioRepositorio.ListarPorId(id);
            return View(funcionario);
        }

        public IActionResult Alterar(FuncionarioModel funcionario)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _funcionarioRepositorio.Atualizar(funcionario);
                    TempData["MesnagemSucesso"] = "Funcionário cadastrado com sucesso.";
                    return RedirectToAction("Consultar");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MesnagemSucesso"] = $"Ops, não conseguimos cadastra o funcionario, tente novamente, erro: " + erro;
            }

            return View("Editar", funcionario);
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
