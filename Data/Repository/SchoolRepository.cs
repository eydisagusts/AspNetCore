using AspNetCore2.Data.Interfaces;
using AspNetCore2.Modles;
using AspNetCore2.Modles.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;

namespace AspNetCore2.Data.Repository;

public class SchoolRepository : IRepository
{
    private readonly SchoolContext _dbContext;

    public SchoolRepository()
    {
        _dbContext = new SchoolContext();
    }


    // Student
    public async Task<List<StudentReadDTO>> GetAllStudentsAsync()
    {
        List<Student> students;

        using (var db = _dbContext)
        {
            students = await db.Students.Include(g => g.Group).ToListAsync();
        }

        List<StudentReadDTO> result = new List<StudentReadDTO>();

        foreach (Student stud in students)
        {
            StudentReadDTO studToAdd = new StudentReadDTO();

            studToAdd.StudentId = stud.StudentId;
            studToAdd.FirstName = stud.FirstName;
            studToAdd.LastName = stud.LastName;
            studToAdd.GroupId = stud.GroupId;
            studToAdd.GroupName = stud.Group.Name;

            result.Add(studToAdd);
        }

        return result;
    }

    public async Task<StudentDetailsDTO> GetStudentByIdAsync(int id)
    {
        Student? s;

        using (var db = _dbContext)
        {
            s = await db.Students.Include(g => g.Group).Include(m => m.Marks).ThenInclude(mark => mark.Subject)
                .FirstOrDefaultAsync(x => x.StudentId == id);
        }

        StudentDetailsDTO studToReturn = new StudentDetailsDTO
        {
            StudentId = s.StudentId,
            FirstName = s.FirstName,
            LastName = s.LastName,
            GroupId = s.GroupId,
            GroupName = s.Group?.Name,
            Marks = s.Marks.Select(m => new MarkSummaryDTO
            {
                SubjectTitle = m.Subject.Title,
                MarkValue = m.MarkValue,
                DateTime = m.DateTime
            }).ToList()
        };

        return studToReturn;
    }

    public async Task CreateStudentAsync(StudentCreateDTO dto)
    {
        using (var db = _dbContext)
        {
            Student student = new Student
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                GroupId = dto.GroupId
            };

            await db.Students.AddAsync(student);
            await db.SaveChangesAsync();
        }
    }

    public async Task<StudentReadDTO?> UpdateStudentAsync(int id, StudentCreateDTO dto)
    {
        using (var db = _dbContext)
        {
            var studentToUpdate = await db.Students
                .Include(s => s.Group)
                .FirstOrDefaultAsync(x => x.StudentId == id);

            if (studentToUpdate == null)
            {
                return null;
            }

            studentToUpdate.FirstName = dto.FirstName;
            studentToUpdate.LastName = dto.LastName;
            studentToUpdate.GroupId = dto.GroupId;

            await db.SaveChangesAsync();

            return new StudentReadDTO
            {
                StudentId = studentToUpdate.StudentId,
                FirstName = studentToUpdate.FirstName,
                LastName = studentToUpdate.LastName,
                GroupId = studentToUpdate.GroupId,
                GroupName = studentToUpdate.Group.Name
            };
        }
    }

    public async Task<bool> DeleteStudentAsync(int id)
    {
        Student studentToDelete;

        using (var db = _dbContext)
        {
            studentToDelete = db.Students.FirstOrDefault(x => x.StudentId == id);

            if (studentToDelete == null)
            {
                return false;
            }
            else
            {
                db.Students.Remove(studentToDelete);
                await db.SaveChangesAsync();
                return true;
            }
        }
    }
    
    
    // Group

    public Task<List<GroupDTO>> GetAllGroupsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GroupDTO> GetGroupByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CreateGroupAsync(GroupDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<GroupDTO> UpdateGroupAsync(int id, GroupDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteGroupAsync(int id)
    {
        throw new NotImplementedException();
    }
    
    
    
    // Marks

    public Task<List<MarkDTO>> GetAllMarksAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MarkDTO> GetMarkByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CreateMarkAsync(MarkDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<MarkDTO> UpdateMarkAsync(int id, MarkDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteMarkAsync(int id)
    {
        throw new NotImplementedException();
    }

    
    
    // Subject
    
    public Task<List<SubjectReadDTO>> GetAllSubjectsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SubjectReadDTO> GetSubjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CreateSubjectAsync(SubjectCreateDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<SubjectReadDTO> UpdateSubjectAsync(int id, SubjectUpdateDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSubjectAsync(int id)
    {
        throw new NotImplementedException();
    }
    
    
    
    // SubjectTeacher

    public Task<List<SubjectTeacherReadDTO>> GetAllSubjectTeachersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SubjectTeacherReadDTO> GetSubjectTeacherByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CreateSubjectTeacherAsync(SubjectTeacherCreateDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSubjectTeacherAsync(int id)
    {
        throw new NotImplementedException();
    }
    
    
    // Teacher

    public Task<List<TeacherReadDTO>> GetAllTeachersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TeacherReadDTO> GetTeacherByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CreateTeacherAsync(TeacherCreateDTO teacher)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherReadDTO> UpdateTeacherAsync(int id, TeacherUpdateDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTeacherAsync(int id)
    {
        throw new NotImplementedException();
    }
}