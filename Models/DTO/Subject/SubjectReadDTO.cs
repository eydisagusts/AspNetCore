using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles.DTO;

public class SubjectReadDTO
{
    public int SubjectId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Title { get; set; } = null!;
}