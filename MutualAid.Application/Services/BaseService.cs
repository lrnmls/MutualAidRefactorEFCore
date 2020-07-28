using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.Data.DTO;
using MutualAid.Data.Interfaces;
using MutualAid.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Services
{
    public abstract class BaseService<TEntity> : IBaseService where TEntity : BaseEntity
    {
        protected readonly IMapper Mapper;
        private readonly IBaseRepository<TEntity> _baseEntityRepository;

        protected BaseService(IBaseRepository<TEntity> baseEntityRepository, IMapper Mapper)
        {
            _baseEntityRepository = baseEntityRepository;
        }

        public virtual async Task<IEnumerable<DropdownDto>> GetDropdownDtosAsync()
        {
            var entities = await _baseEntityRepository.GetAllAsync();
            return Mapper.Map<IEnumerable<DropdownDto>>(entities);
        }
    }
}
