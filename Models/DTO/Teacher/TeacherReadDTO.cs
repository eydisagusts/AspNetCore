namespace AspNetCore2.Modles.DTO;

public class TeacherReadDTO
{
    public int TeacherId { get; set; }
    
    public string FirstName { get; set; } = null!;
    
    public string LastName { get; set; } = null!;
}