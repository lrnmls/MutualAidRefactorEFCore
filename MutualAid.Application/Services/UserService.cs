using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.Data.DTO;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        //GET methods
        public async Task<UserDto> GetUserByUserIdAsync(int userId)
        {
            var user = await userRepository.GetByIdAsync(userId);
            var userDTO = mapper.Map<UserDto>(user);
            return userDTO;
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var user = await userRepository.GetUserByEmailAsync(email);
            return mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await userRepository.GetAllAsync();
            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        //POST methods
        public async Task<bool> AddUserAsync(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            return await userRepository.AddAsync(user);
        }

        public async Task<bool> UpdateUserAsync(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            return await userRepository.UpdateAsync(user);
        }

        public async Task<bool> DeleteUserAsync(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            return await userRepository.DeleteAsync(user);
        }
    }
}
