namespace AspNetCore2.Modles.DTO;

public class StudentCreateDTO
{
    public string FirstName { get; set; } = null!;
    
    public string LastName { get; set; } = null!;
    
    public int GroupId { get; set; }
}