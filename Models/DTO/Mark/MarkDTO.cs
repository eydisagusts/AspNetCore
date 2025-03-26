namespace AspNetCore2.Modles.DTO;

public class MarkDTO
{
    public int MarkId { get; set; }
    
    // Foreign Key
    public int StudentId { get; set; }
    
    // Foreign Key
    public int SubjectId { get; set; }

    public DateTime DateTime { get; set; } = DateTime.Now;
    
    public int MarkValue { get; set; }
}