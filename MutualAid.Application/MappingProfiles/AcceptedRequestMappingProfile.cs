using AutoMapper;
using MutualAid.Data.DTO;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Application.MappingProfiles
{
    public class AcceptedRequestMappingProfile : Profile
    {
        public AcceptedRequestMappingProfile()
        {
            CreateMap<AcceptedRequest, AcceptedRequestDto>();
            CreateMap<AcceptedRequestDto, AcceptedRequest>();
        }
    }
}
