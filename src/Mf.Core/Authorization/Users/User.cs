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
        public int Age { get; set; } // new Age field added
        
        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string gender, string preferendGender, string location, string[] interests, int age)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                Age = age,
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
