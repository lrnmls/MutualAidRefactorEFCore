using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Interfaces
{
    public interface IUserViewService : IBaseViewService
    {
        //GET
        Task<UserViewModel> GetUserByIdAsync(int userId);
        Task<UserViewModel> GetUserByEmailAsync(string email);
        Task<IEnumerable<UserViewModel>> GetAllUsersAsync();

        //POST
        Task<bool> AddUserAsync(UserViewModel model);
        Task<bool> UpdateUserAsync(UserViewModel model);
        Task<bool> DeleteUserAsync(UserViewModel model);
    }
}
