using MutualAid.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Interfaces
{
    public interface IBaseRepository<TType> where TType : BaseEntity
    {
        //GET
        Task<TType> GetByIdAsync(int id);
        Task<IReadOnlyList<TType>> GetAllAsync();

        //POST
        Task<bool> AddAsync(TType entity);
        Task<bool> UpdateAsync(TType entity);
        Task<bool> DeleteAsync(TType entity);
    }
}
