using AspNetCore2.Modles;
using AspNetCore2.Modles.DTO;

namespace AspNetCore2.Data.Interfaces;

public interface IRepository
{
    
    // Student
    Task<List<StudentReadDTO>> GetAllStudentsAsync();
    
    Task<StudentDetailsDTO> GetStudentByIdAsync(int id);
    
    Task CreateStudentAsync(StudentCreateDTO dto);
    
    Task<StudentReadDTO> UpdateStudentAsync(int id, StudentCreateDTO dto);
    
    Task<bool> DeleteStudentAsync(int id);
    
    
    // Group
    Task<List<GroupDTO>> GetAllGroupsAsync();
    
    Task<GroupDTO> GetGroupByIdAsync(int id);
    
    Task CreateGroupAsync(GroupDTO dto);
    
    Task<GroupDTO> UpdateGroupAsync(int id, GroupDTO dto);
    
    Task<bool> DeleteGroupAsync(int id);
    
    
    // Mark
    Task<List<MarkDTO>> GetAllMarksAsync();
    
    Task<MarkDTO> GetMarkByIdAsync(int id);
    
    Task CreateMarkAsync(MarkDTO dto);
    
    Task<MarkDTO> UpdateMarkAsync(int id, MarkDTO dto);
    
    Task<bool> DeleteMarkAsync(int id);
    
    
    // Subject
    Task<List<SubjectReadDTO>> GetAllSubjectsAsync();
    
    Task<SubjectReadDTO> GetSubjectByIdAsync(int id);
    
    Task CreateSubjectAsync(SubjectCreateDTO dto);
    
    Task<SubjectReadDTO> UpdateSubjectAsync(int id, SubjectUpdateDTO dto);
    
    Task<bool> DeleteSubjectAsync(int id);
    
    
    // SubjectTeacher
    Task<List<SubjectTeacherReadDTO>> GetAllSubjectTeachersAsync();
    
    Task<SubjectTeacherReadDTO> GetSubjectTeacherByIdAsync(int id);
    
    Task CreateSubjectTeacherAsync(SubjectTeacherCreateDTO dto);
    
    Task<bool> DeleteSubjectTeacherAsync(int id);
    
    
    // Teacher
    Task<List<TeacherReadDTO>> GetAllTeachersAsync();
    
    Task<TeacherReadDTO> GetTeacherByIdAsync(int id);
    
    Task CreateTeacherAsync(TeacherCreateDTO teacher);
    
    Task<TeacherReadDTO> UpdateTeacherAsync(int id, TeacherUpdateDTO dto);
    
    Task<bool> DeleteTeacherAsync(int id);
    
}