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
        private readonly IUserViewService userViewService;
        private readonly IAuthViewService authViewService;

        public UserController(IUserViewService userViewService, IAuthViewService authViewService)
        {
            this.userViewService = userViewService;
            this.authViewService = authViewService;
        }

        public IActionResult DeleteUser()
        {
            return View(authViewService.GetCurrentUser());
        }

        public async Task<IActionResult> EditUser(int userId)
        {
            var user = await userViewService.GetUserByIdAsync(userId);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserViewModel model)
        {
            var result = await userViewService.UpdateUserAsync(model);
            if (result)
            {
                TempData["UserEditSuccess"] = "Information successfully updated!";
                return RedirectToAction("MyAccount", "Account");
            }
            return View(model);
        }

        public IActionResult EditUserPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditUserPassword(string existingPassword, string newPassword)
        {
            var user = authViewService.GetCurrentUser();
            var result = await authViewService.ChangeUserPasswordAsync(user.Id, existingPassword, newPassword);
            if (result)
            {
                TempData["ChangePasswordSuccess"] = "You've successfully changed your password.";
                return RedirectToAction("MyAccount", "Account");
            }
            return View();
        }

        public async Task<IActionResult> UserDetails(int userId)
        {
            var user = await userViewService.GetUserByIdAsync(userId);
            return View(user);
        }

        public async Task<IActionResult> ViewAllUsers()
        {
            IList<UserViewModel> users = new List<UserViewModel>();
            var currentUser = authViewService.GetCurrentUser(); 
            var result = await userViewService.GetAllUsersAsync();
            foreach(var user in result)
            {
                if(user.Id != currentUser.Id)
                {
                    users.Add(user);
                }
            }
            return View(users);
        }
    }
}
