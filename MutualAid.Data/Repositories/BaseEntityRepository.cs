using MutualAid.Data.Context;
using MutualAid.Framework.Entities;

namespace MutualAid.Data.Repositories
{
    public abstract class BaseEntityRepository<TType> : BaseRepository<TType> where TType : BaseEntity
    {
        protected BaseEntityRepository(MutualAidContext dbContext) : base(dbContext)
        {
        }
    }
}