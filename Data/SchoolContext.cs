using AspNetCore2.Modles;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore2.Data;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Mark> Marks { get; set; }
    DbSet<Subject> Subjects { get; set; }
    DbSet<SubjectTeacher> SubjectTeachers { get; set; }
    DbSet<Teacher> Teachers { get; set; }
    public string DbPath { get; }

    public SchoolContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
        Console.WriteLine(DbPath);
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>().HasData(
            new Group() { GroupId = 1, Name = "Blue" },
            new Group() { GroupId = 2, Name = "Red" },
            new Group() { GroupId = 3, Name = "Green" },
            new Group() { GroupId = 4, Name = "Yellow" }
        );

        modelBuilder.Entity<Subject>().HasData(
            new Subject() { SubjectId = 1, Title = "Math" },
            new Subject() { SubjectId = 2, Title = "English" },
            new Subject() { SubjectId = 3, Title = "History" },
            new Subject() { SubjectId = 4, Title = "Science" },
            new Subject() { SubjectId = 5, Title = "Computer Programming" }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student()
            {
                StudentId = 1, 
                FirstName = "Jón", 
                LastName = "Jónsson", 
                GroupId = 3
            },
            new Student()
            {
                StudentId = 2,
                FirstName = "Friðrik",
                LastName = "Dór",
                GroupId = 2
            },
            new Student()
                {
                    StudentId = 3,
                    FirstName = "Jóhanna",
                    LastName = "Guðrún",
                    GroupId = 2
                },
            new Student()
            {
                StudentId = 4,
                FirstName = "María",
                LastName = "Ólafsdóttir",
                GroupId = 1
            },
            new Student()
            {
                StudentId = 5,
                FirstName = "Auðunn",
                LastName = "Blöndal",
                GroupId = 4
            },
            new Student()
            {
                StudentId = 6,
                FirstName = "Steinþór",
                LastName = "Steinþórrson",
                GroupId = 4
            },
            new Student()
            {
                StudentId = 7,
                FirstName = "Sverrir Þór",
                LastName = "Sverrirson",
                GroupId = 1
            },
            new Student()
            {
                StudentId = 8,
                FirstName = "Ari",
                LastName = "Eldjárn",
                GroupId = 3
            },
            new Student()
            {
                StudentId = 9,
                FirstName = "Sigga",
                LastName = "Beinteins",
                GroupId = 2
            },
            new Student()
            {
                StudentId = 10,
                FirstName = "Selma",
                LastName = "Björnsdóttir",
                GroupId = 3
            }
        );

        modelBuilder.Entity<Mark>().HasData(
            new Mark()
            {
                MarkId = 1,
                StudentId = 1,
                SubjectId = 2,
                DateTime = new DateTime(2024, 12, 17),
                MarkValue = 90
            },
            new Mark()
            {
                MarkId = 2,
                StudentId = 1,
                SubjectId = 1,
                DateTime = new DateTime(2024, 12, 14),
                MarkValue = 70
            },
            new Mark()
            {
                MarkId = 3,
                StudentId = 2,
                SubjectId = 4,
                DateTime = new DateTime(2024, 12, 14),
                MarkValue = 85
            },
            new Mark()
            {
                MarkId = 4,
                StudentId = 2,
                SubjectId = 5,
                DateTime = new DateTime(2024, 12, 16),
                MarkValue = 80
            },
            new Mark()
            {
                MarkId = 5,
                StudentId = 3,
                SubjectId = 2,
                DateTime = new DateTime(2024, 12, 19),
                MarkValue = 90
            },
            new Mark()
            {
                MarkId = 6,
                StudentId = 3,
                SubjectId = 4,
                DateTime = new DateTime(2025, 1, 10),
                MarkValue = 70
            },
            new Mark()
            {
                MarkId = 7,
                StudentId = 4,
                SubjectId = 1,
                DateTime = new DateTime(2024, 12, 16),
                MarkValue = 65
            },
            new Mark()
            {
                MarkId = 8,
                StudentId = 4,
                SubjectId = 5,
                DateTime = new DateTime(2025, 1, 7),
                MarkValue = 80
            }, 
            new Mark()
            {
                MarkId = 9,
                StudentId = 5,
                SubjectId = 3,
                DateTime = new DateTime(2024, 12, 16),
                MarkValue = 100
            },
            new Mark()
            {
                MarkId = 10,
                StudentId = 5,
                SubjectId = 2,
                DateTime = new DateTime(2024, 12, 19),
                MarkValue = 95
            },
            new Mark()
            {
                MarkId = 11,
                StudentId = 6,
                SubjectId = 4,
                DateTime = new DateTime(2024, 12, 20),
                MarkValue = 65
            },
            new Mark()
            {
                MarkId = 12,
                StudentId = 6,
                SubjectId = 1,
                DateTime = new DateTime(2025, 1, 16),
                MarkValue = 90
            }, 
            new Mark()
            {
                MarkId = 13,
                StudentId = 7,
                SubjectId = 5,
                DateTime = new DateTime(2025, 1, 6),
                MarkValue = 85
            }, 
            new Mark()
            {
                MarkId = 14,
                StudentId = 8,
                SubjectId = 2,
                DateTime = new DateTime(2025, 2, 20),
                MarkValue = 95
            },
            new Mark()
            {
                MarkId = 15,
                StudentId = 9,
                SubjectId = 3,
                DateTime = new DateTime(2025, 12, 19),
                MarkValue = 75
            },
            new Mark()
            {
                MarkId = 16,
                StudentId = 9,
                SubjectId = 1,
                DateTime = new DateTime(2025, 12, 16),
                MarkValue = 90
            }, 
            new Mark()
            {
                MarkId = 17,
                StudentId = 9,
                SubjectId = 5,
                DateTime = new DateTime(2025, 12, 19),
                MarkValue = 75
            },  
            new Mark()
            {
                MarkId = 18,
                StudentId = 10,
                SubjectId = 2,
                DateTime = new DateTime(2025, 1, 16),
                MarkValue = 100
            }
        );

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher() { TeacherId = 1, FirstName = "Jakob", LastName = "Frímann" },
            new Teacher() { TeacherId = 2, FirstName = "Ragnheiður", LastName = "Gröndal" },
            new Teacher() { TeacherId = 3, FirstName = "Björgvin", LastName = "Halldórsson" }
        );

        modelBuilder.Entity<SubjectTeacher>().HasData(
            new SubjectTeacher() { Id = 1, SubjectId = 3, TeacherId = 2 },
            new SubjectTeacher() { Id = 2, SubjectId = 5, TeacherId = 1 },
            new SubjectTeacher() { Id = 3, SubjectId = 1, TeacherId = 3 },
            new SubjectTeacher() { Id = 4, SubjectId = 2, TeacherId = 1 },
            new SubjectTeacher() { Id = 5, SubjectId = 4, TeacherId = 2 }
        );
    }
}
