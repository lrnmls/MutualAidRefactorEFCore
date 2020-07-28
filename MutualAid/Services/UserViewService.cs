using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using MutualAid.Application.Interfaces;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;
using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Services
{
    public class UserViewService : BaseViewService, IUserViewService
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserViewService(IUserService userService, IMapper mapper) : base(mapper, userService)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        //GET methods
        public async Task<UserViewModel> GetUserByEmailAsync(string email)
        {
            var userDto = await userService.GetUserByEmailAsync(email);
            return mapper.Map<UserViewModel>(userDto);
        }

        public async Task<UserViewModel> GetUserByIdAsync(int userId)
        {
            var userDto = await userService.GetUserByUserId(userId);
            return mapper.Map<UserViewModel>(userDto);
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
        {
            var usersDto = await userService.GetAllUsersAsync();
            return mapper.Map<IEnumerable<UserViewModel>>(usersDto);
        }

        //POST methods
        public async Task<bool> AddUserAsync(UserViewModel model)
        {
            var userDto = mapper.Map<UserDto>(model);
            return await userService.AddUserAsync(userDto);
        }

        public async Task<bool> UpdateUserAsync(UserViewModel model)
        {
            var userDto = mapper.Map<UserDto>(model);
            return await userService.UpdateUserAsync(userDto);
        }

        public async Task<bool> DeleteUserAsync(UserViewModel model)
        {
            var userDto = mapper.Map<UserDto>(model);
            return await userService.DeleteUserAsync(userDto);
        }
    }
}
