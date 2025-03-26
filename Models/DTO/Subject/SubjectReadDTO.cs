namespace AspNetCore2.Modles.DTO;

public class SubjectReadDTO
{
    public int SubjectId { get; set; }
    
    public string Title { get; set; } = null!;
    
    public int MarkCount { get; set; }
    
    public int TeacherCount { get; set; }
}