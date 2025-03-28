namespace AspNetCore2.Modles.DTO;

public class TeacherDetailsDTO
{
    public class TeacherDTO
    {
        public int TeacherId { get; set; }
    
        public string FirstName { get; set; } = null!;
    
        public string LastName { get; set; } = null!;
    
        public List<SubjectTeacher> SubjectsTeachers { get; set; } = new List<SubjectTeacher>();
    }
}