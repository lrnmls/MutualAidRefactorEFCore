using AutoMapper;
using MutualAid.Data.DTO;
using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Application.MappingProfiles
{
    public class RequestMappingProfile : Profile
    {
        public RequestMappingProfile()
        {
            CreateMap<Request, RequestDto>();
            CreateMap<RequestDto, Request>();
        }
    }
}
