using MutualAid.Data.Entities;
using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Interfaces
{
    public interface IAuthViewService : IBaseViewService
    {
        //GET
        UserViewModel GetCurrentUser();
        Task<UserViewModel> SignInAsync(string email, string password);
        void LogOff();

        //POST
        Task<bool> RegisterNewUser(RegisterViewModel model);
    }
}
