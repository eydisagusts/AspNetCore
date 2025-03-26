namespace AspNetCore2.Modles;

public class SubjectTeacher
{
    public int Id { get; set; }
    
    // Foreign Key
    public int SubjectId { get; set; }
    
    // Navigation property
    public Subject Subject { get; set; } = null!;
    
    // Foreign Key
    public int TeacherId { get; set; }
    
    // Navigation property
    public Teacher Teacher { get; set; } = null!;
}