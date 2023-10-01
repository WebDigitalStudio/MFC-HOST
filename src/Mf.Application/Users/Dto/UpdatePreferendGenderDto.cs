using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Mf.Users.Dto;

public class UpdatePreferendGenderDto
{
    [Required(ErrorMessage = "Поле 'UserId' обязательно для заполнения.")]
    public string UserId { get; set; }
    
    [Required(ErrorMessage = "Поле 'NewPreferendGender' обязательно для заполнения.")]
    public string NewPreferendGender { get; set; }
}