using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Services
{
    public class BaseViewService : IBaseViewService
    {
        protected readonly IMapper Mapper;
        private readonly IBaseService _baseService;

        public BaseViewService(IMapper mapper, IBaseService baseService)
        {
            Mapper = mapper;
            _baseService = baseService;
        }

        public virtual async Task<IEnumerable<DropdownViewModel>> GetDropdownViewModelsAsync()
        {
            var dtos = await _baseService.GetDropdownDtosAsync();
            return Mapper.Map<IEnumerable<DropdownViewModel>>(dtos);
        }
    }
}
