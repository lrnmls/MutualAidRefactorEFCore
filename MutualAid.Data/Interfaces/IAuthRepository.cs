using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Interfaces
{
    public interface IAuthRepository :IBaseRepository<User>
    {
        //GET
        User GetCurrentUser();
        Task<User> SignInAsync(string email, string password);
        void LogOff();

        //POST
        Task<bool> RegisterUserAsync(User user);
        Task<bool> ChangeUserPasswordAsync(int userId, string existingPassword, string newPassword);
    }
}
