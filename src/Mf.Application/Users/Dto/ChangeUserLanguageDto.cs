using System.ComponentModel.DataAnnotations;

namespace Mf.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}