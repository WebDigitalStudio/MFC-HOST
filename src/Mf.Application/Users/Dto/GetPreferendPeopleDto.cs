using System.Collections.Generic;

namespace Mf.Users.Dto;

public class GetPreferendPeopleDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Location { get; set; }
    public string Gender { get; set; }
    public string PreferendGender { get; set; }
    public string Email { get; set; }
    public string[] Interests { get; set; }
    public int Age { get; set; }
}