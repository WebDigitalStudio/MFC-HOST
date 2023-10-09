using System.ComponentModel.DataAnnotations;

namespace Mf.Users.Dto;

public class GetPreferendPeopleDtoInput
{
    [Required]
    public string PreferendGender { get; set; }
    
    [Required]
    public string Location { get; set; }
    
    public string[] Interests { get; set; }
    
    public int AgeMin { get; set; }
    
    public int AgeMax { get; set; }
}