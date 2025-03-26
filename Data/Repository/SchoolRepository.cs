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

    public async Task<List<GroupDTO>> GetAllGroupsAsync()
    {
        List<Group> groups;

        using (var db = _dbContext)
        {
            groups = await db.Groups.Include(s => s.Students).ToListAsync();
        }

        List<GroupDTO> result = new List<GroupDTO>();

        foreach (Group group in groups)
        {
            GroupDTO groupDto = new GroupDTO();

            groupDto.GroupId = group.GroupId;
            groupDto.Name = group.Name;

            result.Add(groupDto);
        }

        return result;
    }

    public async Task<GroupDTO> GetGroupByIdAsync(int id)
    {
        Group? g;

        using (var db = _dbContext)
        {
            g = await db.Groups.Include(s => s.Students).FirstOrDefaultAsync(x => x.GroupId == id);
        }

        if (g == null)
        {
            return null;
        }

        GroupDTO groupDto = new GroupDTO()
        {
            GroupId = g.GroupId,
            Name = g.Name,
            Students = g.Students.Select(student => new StudentGroupDTO
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
            }).ToList()
        };

        return groupDto;
    }

    public async Task CreateGroupAsync(GroupDTO dto)
    {
        using (var db = _dbContext)
        {
            Group group = new Group
            {
                GroupId = dto.GroupId,
                Name = dto.Name
            };

            await db.Groups.AddAsync(group);
            await db.SaveChangesAsync();
        }
    }

    public async Task<GroupDTO> UpdateGroupAsync(int id, GroupDTO dto)
    {
        using (var db = _dbContext)
        {
            var groupToUpdate = await db.Groups
                .FirstOrDefaultAsync(x => x.GroupId == id);

            if (groupToUpdate == null)
            {
                return null;
            }

            groupToUpdate.GroupId = dto.GroupId;
            groupToUpdate.Name = dto.Name;

            await db.SaveChangesAsync();

            return new GroupDTO
            {
                GroupId = groupToUpdate.GroupId,
                Name = groupToUpdate.Name,
            };
        }
    }

    public async Task<bool> DeleteGroupAsync(int id)
    {
        Group groupToDelete;

        using (var db = _dbContext)
        {
            groupToDelete = db.Groups.FirstOrDefault(x => x.GroupId == id);

            if (groupToDelete == null)
            {
                return false;
            }
            else
            {
                db.Groups.Remove(groupToDelete);
                await db.SaveChangesAsync();
                return true;
            }
        }
    }



    // Marks

    public async Task<List<MarkDTO>> GetAllMarksAsync()
    {
        {
            using (var db = _dbContext)
            {
                var marks = await db.Marks
                    .Include(m => m.Student)
                    .Include(m => m.Subject)
                    .ToListAsync();

                List<MarkDTO> result = new List<MarkDTO>();

                foreach (var mark in marks)
                {
                    var markDto = new MarkDTO
                    {
                        MarkId = mark.MarkId,
                        StudentId = mark.StudentId,
                        SubjectId = mark.SubjectId,
                        DateTime = mark.DateTime,
                        MarkValue = mark.MarkValue
                    };

                    result.Add(markDto);
                }

                return result;
            }
        }
    }

    public async Task<MarkDTO> GetMarkByIdAsync(int id)
    {
        Mark? m;

        using (var db = _dbContext)
        {
            m = await db.Marks.FirstOrDefaultAsync(x => x.MarkId == id);
        }

        if (m == null)
        {
            return null;
        }

        MarkDTO markDto = new MarkDTO()
        {
            MarkId = m.MarkId,
            MarkValue = m.MarkValue,
            StudentId = m.StudentId,
            SubjectId = m.SubjectId,
            DateTime = m.DateTime,
        };

        return markDto;
    }

    public async Task CreateMarkAsync(MarkDTO dto)
    {
        using (var db = _dbContext)
        {
            Mark mark = new Mark
            {
                StudentId = dto.StudentId,
                SubjectId = dto.SubjectId,
                DateTime = dto.DateTime,
                MarkValue = dto.MarkValue,
            };

            await db.Marks.AddAsync(mark);
            await db.SaveChangesAsync();
        }
    }

    public async Task<MarkDTO> UpdateMarkAsync(int id, MarkDTO dto)
    {
        using (var db = _dbContext)
        {
            var markToUpdate = await db.Marks.FirstOrDefaultAsync(x => x.MarkId == id);

            if (markToUpdate == null)
            {
                return null;
            }
            
            markToUpdate.DateTime = dto.DateTime;
            markToUpdate.MarkValue = dto.MarkValue;

            await db.SaveChangesAsync();

            return new MarkDTO()
            {
                MarkId = markToUpdate.MarkId,
                StudentId = markToUpdate.StudentId,
                SubjectId = markToUpdate.SubjectId,
                DateTime = markToUpdate.DateTime,
                MarkValue = markToUpdate.MarkValue,
            };
        }
    }

    public async Task<bool> DeleteMarkAsync(int id)
    {
        Mark markToDelete;

        using (var db = _dbContext)
        {
            markToDelete = await db.Marks.FirstOrDefaultAsync(x => x.MarkId == id);

            if (markToDelete == null)
            {
                return false;
            }
            else
            {

                db.Marks.Remove(markToDelete);
                await db.SaveChangesAsync();
                return true;
            }
        }
    }



// Subject
    
    public async Task<List<SubjectReadDTO>> GetAllSubjectsAsync()
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