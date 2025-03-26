namespace AspNetCore2.Modles.DTO;

public class MarkSummaryDTO
{
    public string SubjectTitle { get; set; } = null!;
    
    public int MarkValue { get; set; }
    
    public DateTime DateTime { get; set; }
}