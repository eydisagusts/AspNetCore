using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Modles.DTO;

public class StudentReadDTO
{
   
    public int StudentId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; } = null!;
    public int GroupId { get; set; }

}