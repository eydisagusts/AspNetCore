using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles;

public class Student
{
    public int StudentId { get; set; }

    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; } 
    
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }
    
    // Foreign Key
    public int GroupId { get; set; }
    
    // Navigation property
    public Group Group { get; set; } = null!;
    
    public List<Mark> Marks { get; set; } = new List<Mark>();
}