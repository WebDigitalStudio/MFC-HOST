using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Mf.Authorization.Users;

namespace Mf.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        
        public string Gender { get; set; }
        
        public string PreferendGender { get; set; }

        public string Location { get; set; }
        
        public int Age { get; set; }
        
        public string[] Interests { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
