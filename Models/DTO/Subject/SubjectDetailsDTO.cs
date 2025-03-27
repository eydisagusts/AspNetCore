namespace AspNetCore2.Modles.DTO;

public class SubjectDetailsDTO
{
    public int SubjectId { get; set; }
    
    public string Title { get; set; } = null!;
    
    public List<MarkSubjectDTO> Marks { get; set; } = new List<MarkSubjectDTO>();
}