using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        //GET
        Task<User> GetUserByEmailAsync(string email);
    }
}
