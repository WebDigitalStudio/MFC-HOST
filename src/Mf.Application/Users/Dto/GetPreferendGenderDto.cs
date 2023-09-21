using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Mf.Users.Dto
{
    public class GetPreferendGenderDto : IValidatableObject
    {
        [Required(ErrorMessage = "Поле 'UserId' обязательно для заполнения.")]
        public string UserId { get; set; }
        
        public string PreferendGender { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(UserId))
            {
                yield return new ValidationResult("Поле 'UserId' не может быть пустым или содержать только пробелы.", new[] { nameof(UserId) });
            }
            
            if (PreferendGender != null && PreferendGender.Length > 50)
            {
                yield return new ValidationResult("Поле 'PreferendGender' не должно превышать 50 символов.", new[] { nameof(PreferendGender) });
            }
        }
    }
}