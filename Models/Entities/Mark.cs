namespace AspNetCore2.Modles;

public class Mark
{
    public int MarkId { get; set; }
    
    // Foreign Key
    public int StudentId { get; set; }
    
    // Navigation property
    public Student Student { get; set; }  = null!;
    
    // Foreign Key
    public int SubjectId { get; set; }
    
    // Navigation property
    public Subject Subject { get; set; } = null!;

    public DateTime DateTime { get; set; } = DateTime.Now;
    
    public int MarkValue { get; set; }
}