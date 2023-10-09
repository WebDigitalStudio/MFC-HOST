using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace Mf.Users.Dto;

public class UpdatePreferendGenderDto : IValidatableObject
{
    [Required(ErrorMessage = "Поле 'UserId' обязательно для заполнения.")]
    public long UserId { get; set; }

    [Required(ErrorMessage = "Поле 'NewPreferendGender' обязательно для заполнения.")]
    public string NewPreferendGender { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        string[] genders = { "male", "female", "other" };
        
        if (string.IsNullOrWhiteSpace(NewPreferendGender))
        {
            yield return new ValidationResult(
                "Поле 'NewPreferendGender' не может быть пустым или содержать только пробелы.",
                new[] { nameof(NewPreferendGender) });
        }

        if (UserId != null)
        {
            yield return new ValidationResult("Поле 'UserId' не может быть пустым или содержать только пробелы.",
                new[] { nameof(UserId) });
        }
        
        if (!genders.Contains(NewPreferendGender))
        {
            yield return new ValidationResult(
                "Поле 'NewPreferendGender' может содержать только male, female или other.",
                new[] { nameof(NewPreferendGender) });
        }
    }
}