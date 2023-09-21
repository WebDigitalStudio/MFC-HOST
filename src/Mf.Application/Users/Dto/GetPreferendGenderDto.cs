using System.ComponentModel.DataAnnotations;

namespace Mf.Users.Dto
{
    public class GetPreferendGenderDto
    {
        [Required]
        public string UserId { get; set; }
        
        public string PreferendGender { get; set; }
    }
}