using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles;

public class Subject
{
    public int SubjectId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Title { get; set; }
    
    List<Mark> Marks { get; set; } = new List<Mark>();
    
    List<SubjectTeacher> subjectsTeachers = new List<SubjectTeacher>();
}