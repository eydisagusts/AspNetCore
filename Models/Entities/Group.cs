using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles;

public class Group
{
    public int GroupId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    // Each Group can have multiple Students
    public List<Student> Students { get; set; } = new List<Student>();
}