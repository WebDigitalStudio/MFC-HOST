using AutoMapper;
using Mf.Authorization.Users;
using Mf.Users.Dto;

namespace Mf;

internal static class CustomDtoMapper
{
    public static void CreateMappings(IMapperConfigurationExpression configuration)
    {
        configuration.CreateMap<User, GetPreferendPeopleDto>();
    }
}