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

        public ActionResult RegisterNewUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterNewUser(RegisterViewModel model)
        {
            var result = await authViewService.RegisterNewUser(model);
            if (result)
            {
                TempData["RegistrationSuccess"] = "You're one step closer to using Mutual Aid! Please sign in to continue.";
                return RedirectToAction("SignIn", "Account");
            }
            return View(model);
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(string email, string password)
        {
            var user = await authViewService.SignInAsync(email, password);
            if(user != null)
            {
                if (!user.isAdmin)
                {
                    return RedirectToAction("Index", "User", user);
                }
                return RedirectToAction("Index", "Admin", user);
            }
            TempData["UserNotFound"] = "No user exists with this email, please try again or register an account.";
            return View();
        }

        public IActionResult LogOff()
        {
            authViewService.LogOff();
            return RedirectToAction("Index", "Home");
        }
    }
}
