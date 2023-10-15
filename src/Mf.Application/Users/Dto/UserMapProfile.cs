using AutoMapper;
using Mf.Authorization.Users;

namespace Mf.Users.Dto
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<UserDto, User>()
                .ForMember(x => x.Roles, opt => opt.Ignore())
                .ForMember(x => x.CreationTime, opt => opt.Ignore());

            CreateMap<CreateUserInput, User>();
            CreateMap<CreateUserInput, User>().ForMember(x => x.Roles, opt => opt.Ignore());
        }   
    }
}
