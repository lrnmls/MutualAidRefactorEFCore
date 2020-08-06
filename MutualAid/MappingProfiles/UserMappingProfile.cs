using MutualAid.UI.Models;
using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.MappingProfiles
{
    public class UserMappingProfile : AutoMapper.Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserDto, UserViewModel>();
            CreateMap<UserViewModel, UserDto>();
            CreateMap<UserDto, RegisterViewModel>();
            CreateMap<RegisterViewModel, UserDto>();
            CreateMap<UserViewModel, UserPasswordViewModel>();
            CreateMap<UserPasswordViewModel, UserViewModel>();
            CreateMap<UserViewModel, UserPasswordViewModel>()
                .ForMember(x => x.ExistingPassword, opt => opt.MapFrom(src => src.Password));
            CreateMap<UserPasswordViewModel, UserViewModel>()
              .ForMember(x => x.Password, opt => opt.MapFrom(src => src.ExistingPassword));
        }
    }
}
