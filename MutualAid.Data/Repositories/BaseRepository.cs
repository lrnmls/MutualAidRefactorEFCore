using Microsoft.EntityFrameworkCore;
using MutualAid.Data.Context;
using MutualAid.Data.Interfaces;
using MutualAid.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Repositories
{
    public class BaseRepository<TType> : IBaseRepository<TType> where TType : BaseEntity
    {
        protected readonly MutualAidContext DbContext;

        public BaseRepository(MutualAidContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        //GET methods
        public async Task<TType> GetByIdAsync(int id)
        {
            return await DbContext.Set<TType>().FindAsync(id);
        }

        //public async Task<IReadOnlyList<TType>> GetAllByIdAsync(int id)
        //{
        //    return await DbContext.Set<IReadOnlyList<TType>>().FindAsync(id);
        //}

        public async Task<IReadOnlyList<TType>> GetAllAsync()
        {
            return await DbContext.Set<TType>().ToListAsync();
        }

        //POST methods
        public async Task<bool> AddAsync(TType entity)
        {
            DbContext.Set<TType>().Add(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> UpdateAsync(TType entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(TType entity)
        {
            DbContext.Set<TType>().Remove(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }
    }
}
