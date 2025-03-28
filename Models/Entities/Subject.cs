using System.ComponentModel.DataAnnotations;
using AspNetCore2.Modles.DTO;

namespace AspNetCore2.Modles;

public class Subject
{
    public int SubjectId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    public List<Mark> Marks { get; set; } = new List<Mark>();
    
    public List<SubjectTeacher> subjectsTeachers = new List<SubjectTeacher>();
    
}