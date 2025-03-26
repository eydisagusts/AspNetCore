using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles;

public class Teacher
{
    public int TeacherId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; } 
    
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }
    
    List<SubjectTeacher> subjectsTeachers = new List<SubjectTeacher>();
}