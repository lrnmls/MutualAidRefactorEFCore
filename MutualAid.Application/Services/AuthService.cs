using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Services
{
    public class AuthService : BaseService<User>, IAuthService
    {
        private readonly IAuthRepository authRepository;
        private readonly IMapper mapper;

        public AuthService(IAuthRepository authRepository, IMapper mapper) : base(authRepository, mapper)
        {
            this.authRepository = authRepository;
            this.mapper = mapper;
        }

        //GET methods
        public UserDto GetCurrentUser()
        {
            var user = authRepository.GetCurrentUser();
            return mapper.Map<UserDto>(user);
        }

        //POST methods
        public async Task<bool> RegisterUserAsync(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            return await authRepository.RegisterUserAsync(user);
        }

        public async Task<UserDto> SignInAsync(string email, string password)
        {
            var user = await authRepository.SignInAsync(email, password);
            return mapper.Map<UserDto>(user);
        }

        public void LogOff()
        {
            authRepository.LogOff();
        }

        public async Task<bool> ChangeUserPasswordAsync(int userId, string existingPassword, string newPassword)
        {
            var result= await authRepository.ChangeUserPasswordAsync(userId, existingPassword, newPassword);
            return result;
        }
    }
}
