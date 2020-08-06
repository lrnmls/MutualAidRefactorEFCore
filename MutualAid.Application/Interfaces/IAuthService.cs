using MutualAid.Data.Entities;
using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Interfaces
{
    public interface IAuthService : IBaseService
    {
        //GET
        UserDto GetCurrentUser();
        Task<UserDto> SignInAsync(string email, string password);
        void LogOff();

        //POST
        Task<bool> RegisterUserAsync(UserDto userDto);
        Task<bool> ChangeUserPasswordAsync(int userId, string existingPassword, string newPassword);
    }
}
