using AutoMapper;
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
    public class AuthViewService : BaseViewService, IAuthViewService
    {
        private readonly IUserService userService;
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public AuthViewService(IUserService userService, IMapper mapper, IAuthService authService) : base(mapper, userService)
        {
            this.userService = userService;
            this.mapper = mapper;
            this.authService = authService;
        }

        public UserViewModel GetCurrentUser()
        {
            var user = authService.GetCurrentUser();
            return mapper.Map<UserViewModel>(user);
        }

        public async Task<bool> RegisterNewUser(RegisterViewModel model)
        {
            var userEntity = mapper.Map<UserDto>(model);
            var userResult = await authService.RegisterNewUser(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<UserViewModel> SignInAsync(string email, string password)
        {
            var user = await authService.SignInAsync(email, password);
            return mapper.Map<UserViewModel>(user);
        }

        public void LogOff()
        {
            authService.LogOff();
        }
    }
}
