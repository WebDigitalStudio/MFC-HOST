using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.Extensions;
using Mf.Validation;

namespace Mf.Authorization.Accounts.Dto
{
    public class RegisterInput : IValidatableObject
    {
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }
        
        [Required]
        public string Gender { get; set; }
        
        public string PreferendGender { get; set; }
        
        [Required]
        public string Location { get; set; }
        
        public string[] Interests { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        [DisableAuditing]
        public string CaptchaResponse { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!UserName.IsNullOrEmpty())
            {
                if (!UserName.Equals(EmailAddress) && ValidationHelper.IsEmail(UserName))
                {
                    yield return new ValidationResult("Username cannot be an email address unless it's the same as your email address!");
                }
            }
        }
    }
}
