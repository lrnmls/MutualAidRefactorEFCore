using AutoMapper;
using MutualAid.Data.DTO;
using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace MutualAid.UI.MappingProfiles
{
    public class RequestMappingProfile : Profile
    {
        public RequestMappingProfile()
        {
            CreateMap<RequestDto, RequestViewModel>();
            CreateMap<RequestViewModel, RequestDto>();
            CreateMap<RequestViewModel, UserViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.UserId));
            CreateMap<UserViewModel, RequestViewModel>()
                .ForMember(x => x.UserId, opt => opt.MapFrom(src => src.Id));
            CreateMap<RequestDto, UserViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.UserId));
            CreateMap<UserViewModel, RequestDto>()
                .ForMember(x => x.UserId, opt => opt.MapFrom(src => src.Id));
        }
    }
}

