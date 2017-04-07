using AutoMapper;
using DbEntity;
using RegistrationExample.Models;

namespace RegistrationExample
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile<UserProfile>();
            });
        }
    }

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>().ForMember(dest => dest.RoleName, 
                source => source.MapFrom(user => user.Role.Name));
            CreateMap<User, UserViewModel>().ForMember(dest => dest.RoleId, 
                source => source.MapFrom(user => user.Role.Id));
        }
    }
}