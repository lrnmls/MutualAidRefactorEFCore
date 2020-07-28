using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Interfaces
{
    public interface IUserService : IBaseService
    {
        //GET
        Task<UserDto> GetUserByUserId(int userId);
        Task<UserDto> GetUserByEmailAsync(string email);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();

        //POST
        Task<bool> AddUserAsync(UserDto userDto);
        Task<bool> UpdateUserAsync(UserDto userDto);
        Task<bool> DeleteUserAsync(UserDto userDto);
    }
}
