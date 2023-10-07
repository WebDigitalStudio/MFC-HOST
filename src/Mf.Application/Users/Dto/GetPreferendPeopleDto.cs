using System.ComponentModel.DataAnnotations;

namespace Mf.Users.Dto;

public class GetPreferendPeopleDto
{
    [Required]
    public string PreferendGender { get; set; }
    
    [Required]
    public string Location { get; set; }
    
    public string[] Interests { get; set; }
    
    public int ageMin { get; set; }
    
    public int ageMax { get; set; }
}