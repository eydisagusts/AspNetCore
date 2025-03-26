using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles.DTO;

public class GroupDTO
{
    public int GroupId { get; set; }
    public string Name { get; set; }
    
    public List<Student> Students { get; set; } = new List<Student>();
}