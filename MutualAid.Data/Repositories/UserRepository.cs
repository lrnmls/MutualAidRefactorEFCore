using Microsoft.EntityFrameworkCore;
using MutualAid.Data.Context;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Repositories
{
    public class UserRepository : BaseEntityRepository<User>, IUserRepository
    {
        public UserRepository(MutualAidContext dbContext) : base(dbContext)
        {
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await DbContext.Set<User>().FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
