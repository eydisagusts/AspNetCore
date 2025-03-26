namespace AspNetCore2.Modles.DTO;

public class SubjectTeacherReadDTO
{
    public int Id { get; set; }

    public int SubjectId { get; set; }
    
    public string SubjectTitle { get; set; } = null!;

    public int TeacherId { get; set; }
    
    public string TeacherName { get; set; } = null!;
}