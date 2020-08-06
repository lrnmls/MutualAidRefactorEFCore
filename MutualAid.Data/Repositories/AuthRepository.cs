using Microsoft.AspNetCore.Http;
using MutualAid.Data.Context;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Repositories
{
    public class AuthRepository : BaseEntityRepository<User>, IAuthRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IUserRepository userRepository;
        public static string SessionKey = "Auth_User";

        ISession Session => contextAccessor.HttpContext.Session;

        public AuthRepository(MutualAidContext dbContext, IUserRepository userRepository, IHttpContextAccessor contextAccessor) : base(dbContext)
        {
            this.userRepository = userRepository;
            this.contextAccessor = contextAccessor;
        }

        public User GetCurrentUser()
        {
            var email = Session.GetString(SessionKey);

            if (!String.IsNullOrEmpty(email))
            {
                var user = userRepository.GetUserByEmailAsync(email).Result;
                return user;
            }
            return null;
        }

        public async Task<bool> RegisterUserAsync(User user)
        {
            var userExists = userRepository.GetUserByEmailAsync(user.Email);
            if (userExists.Result == null)
            {
                var hashProvider = new HashProvider();
                var passwordHash = hashProvider.HashPassword(user.Password);

                user.Password = passwordHash.Password;
                user.Salt = passwordHash.Salt;
                user.Created = DateTime.Now;

                var result = await userRepository.AddAsync(user);

                if (result)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<User> SignInAsync(string email, string password)
        {
            var user = await userRepository.GetUserByEmailAsync(email);
            if(user != null)
            {
                var hashProvider = new HashProvider();
                var passwordsMatch = hashProvider.VerifyPasswordMatch(user.Password, password, user.Salt);

                if (passwordsMatch)
                {
                    Session.SetString(SessionKey, user.Email);
                    return user;
                }
            }
            return null;
        }

        public void LogOff()
        {
            Session.Clear();
        }

        public async Task<bool> ChangeUserPasswordAsync(int userId, string existingPassword, string newPassword)
        {
            var hashProvider = new HashProvider();
            var user = await userRepository.GetByIdAsync(userId);

            if (user != null && hashProvider.VerifyPasswordMatch(user.Password, existingPassword, user.Salt))
            {
                var newHash = hashProvider.HashPassword(newPassword);
                user.Password = newHash.Password;
                user.Salt = newHash.Salt;
            }
            var result = await userRepository.UpdateAsync(user);
            return result;
        }
    }

    public class HashProvider
    {
        private const int WorkFactor = 10000;

        public class HashedPassword
        {
            public HashedPassword(string password, string salt)
            {
                this.Password = password;
                this.Salt = salt;
            }
            public string Password { get; }

            public string Salt { get; }
        }

        public HashedPassword HashPassword(string plainTextPassword)
        {
            //Create the hashing provider
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(plainTextPassword, 8, WorkFactor);

            //Get the Hashed Password
            byte[] hash = rfc.GetBytes(20);

            //Set the SaltValue
            string salt = Convert.ToBase64String(rfc.Salt);

            //Return the Hashed Password
            return new HashedPassword(Convert.ToBase64String(hash), salt);
        }

        public bool VerifyPasswordMatch(string existingHashedPassword, string plainTextPassword, string salt)
        {
            byte[] saltArray = Convert.FromBase64String(salt);      //gets us the byte[] array representation

            //Create the hashing provider
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(plainTextPassword, saltArray, WorkFactor);

            //Get the hashed password
            byte[] hash = rfc.GetBytes(20);

            //Compare the hashed password values
            string newHashedPassword = Convert.ToBase64String(hash);

            return (existingHashedPassword == newHashedPassword);
        }
    }
}
