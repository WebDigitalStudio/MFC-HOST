using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;

namespace Mf.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";
        
        public string Gender { get; set; } // new Gender field added
        public string PreferendGender { get; set; }  // new PreferendGender field added
        public string Location { get; set; }  // new Location field added
        public string[] Interests { get; set; }  
        
        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string gender, string preferendGender, string location, string[] interests)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                Gender = gender,
                PreferendGender = preferendGender,
                Location = location,
                Interests = interests,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
        
    }
}
