using Microsoft.AspNetCore.Mvc;
using LightInvestApp.Models;

namespace LightInvestApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Adicionar lógica de autenticação aqui
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Adicionar lógica para envio de e-mail de recuperação
            TempData["Message"] = "E-mail de recuperação enviado com sucesso.";
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Adicionar lógica para registro de usuário
            TempData["Message"] = "Registro realizado com sucesso.";
            return RedirectToAction("Login");
        }
    }
}

