using Microsoft.AspNetCore.Mvc;
using ProjetoFuncionario.Models;
using ProjetoFuncionario.Repositorios.Interface;

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

        public IActionResult Consultar()
        {
            return View();
        }


        public IActionResult Editar()
        {
            return View();
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
