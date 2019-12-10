using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopOficial.Models;
using RoleTopOficial.Repositories;
using RoleTopOficial.ViewModel;

namespace RoleTopOficial.Controllers
{
    public class CadastrarController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Cadastro()
        {


            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return View();
            }


            
        }
        public IActionResult Login()
        {

            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    ClienteViewModel clienteviewmodell = new ClienteViewModel("");
                    return View(clienteviewmodell);
            }

        }

        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
                Cliente cliente = clienteRepository.ObterPor(form["Nome"]);
                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                return RedirectToAction("index","Cliente");

            
        }

        [HttpPost]
        public IActionResult Cadastro(IFormCollection form)
        {
            try
            {

                if( form["Senha"] == form["RepetirSenha"] )
                {
                        
                    Cliente cliente = new Cliente(form["nome"],form["cpf"],form["telefone"],form["senha"],form["email"]);
                    clienteRepository.Inserir(cliente);
                    HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                    return RedirectToAction("index","Cliente");
                }

            }catch(Exception e)
            
            {
                return View("Fracasso");
            }

            return View("Fracasso");

        }

    }
}
