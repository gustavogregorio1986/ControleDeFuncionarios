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
                    TempData["MensagemSucesso"] = "Funcionário alteardo com sucesso.";
                    return RedirectToAction("Consultar");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar o funcionario, tente novamente, erro: " + erro;
            }

            return View("Editar", funcionario);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            FuncionarioModel funcionario = _funcionarioRepositorio.ListarPorId(id);
            return View(funcionario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                
                bool apagado = _funcionarioRepositorio.Apagar(id);

                if(apagado)
                {
                    TempData["MensagemSucesso"] = "Funcionário apagado com sucesso.";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar o funcionario ";
                }

                return RedirectToAction("Consultar");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar o funcionario, tente novamente, erro: " + erro;
                return RedirectToAction("Consultar");
            }
        }
    }
}
