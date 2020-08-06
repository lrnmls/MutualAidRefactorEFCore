using MutualAid.Data.DTO;
using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.MappingProfiles
{
    public class AcceptedRequestMappingProfile : AutoMapper.Profile
    {
        public AcceptedRequestMappingProfile()
        {
            CreateMap<AcceptedRequestDto, AcceptedRequestViewModel>();
            CreateMap<AcceptedRequestViewModel, AcceptedRequestDto>();
        }
    }
}
