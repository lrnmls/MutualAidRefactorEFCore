using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MutualAid.Data.Entities;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;
using MutualAidRefactorEFCore.Data.DTO;

namespace MutualAid.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthViewService authViewService;

        public AccountController(IAuthViewService authViewService)
        {
            this.authViewService = authViewService;
        }

        public ActionResult MyAccount()
        {
            return View(authViewService.GetCurrentUser());
        }

        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(RegisterViewModel model)
        {
            var result = await authViewService.RegisterNewUser(model);
            if (result)
            {
                var user = authViewService.GetCurrentUser();
                if(user == null)
                {
                    TempData["RegistrationSuccess"] = "You're one step closer to using Mutual Aid! Please sign in to continue.";
                    return RedirectToAction("SignIn", "Account");
                }
                if(user.isAdmin)
                {
                    TempData["UserRegistrationSuccess"] = "User successfully added!";
                    return RedirectToAction("MyAccount", "Account");
                }
            }
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string email, string password)
        {
            var user = await authViewService.SignInAsync(email, password);
            if(user != null)
            {
                return RedirectToAction("MyAccount", "Account", user);
            }
            return View();
        }

        public IActionResult LogOff()
        {
            authViewService.LogOff();
            return RedirectToAction("Index", "Home");
        }
    }
}
