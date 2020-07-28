using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;

namespace MutualAid.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthViewService authViewService;

        public UserController(IAuthViewService authViewService)
        {
            this.authViewService = authViewService;
        }
        public IActionResult Index()
        {
            return View(authViewService.GetCurrentUser());
        }
    }
}
