namespace AspNetCore2.Modles.DTO;

public class GroupDetailsDTO
{
   
        public int GroupId { get; set; }
        public string Name { get; set; }
    
        public List<StudentGroupDTO> Students { get; set; } = new List<StudentGroupDTO>();
    
}