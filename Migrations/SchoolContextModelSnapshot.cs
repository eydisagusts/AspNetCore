﻿// <auto-generated />
using System;
using AspNetCore2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCore2.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("AspNetCore2.Modles.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "Blue"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Red"
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Green"
                        },
                        new
                        {
                            GroupId = 4,
                            Name = "Yellow"
                        });
                });

            modelBuilder.Entity("AspNetCore2.Modles.Mark", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("MarkValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MarkId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            MarkId = 1,
                            DateTime = new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 90,
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            MarkId = 2,
                            DateTime = new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 70,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            MarkId = 3,
                            DateTime = new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 85,
                            StudentId = 2,
                            SubjectId = 4
                        },
                        new
                        {
                            MarkId = 4,
                            DateTime = new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 80,
                            StudentId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            MarkId = 5,
                            DateTime = new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 90,
                            StudentId = 3,
                            SubjectId = 2
                        },
                        new
                        {
                            MarkId = 6,
                            DateTime = new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 70,
                            StudentId = 3,
                            SubjectId = 4
                        },
                        new
                        {
                            MarkId = 7,
                            DateTime = new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 65,
                            StudentId = 4,
                            SubjectId = 1
                        },
                        new
                        {
                            MarkId = 8,
                            DateTime = new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 80,
                            StudentId = 4,
                            SubjectId = 5
                        },
                        new
                        {
                            MarkId = 9,
                            DateTime = new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 100,
                            StudentId = 5,
                            SubjectId = 3
                        },
                        new
                        {
                            MarkId = 10,
                            DateTime = new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 95,
                            StudentId = 5,
                            SubjectId = 2
                        },
                        new
                        {
                            MarkId = 11,
                            DateTime = new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 65,
                            StudentId = 6,
                            SubjectId = 4
                        },
                        new
                        {
                            MarkId = 12,
                            DateTime = new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 90,
                            StudentId = 6,
                            SubjectId = 1
                        },
                        new
                        {
                            MarkId = 13,
                            DateTime = new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 85,
                            StudentId = 7,
                            SubjectId = 5
                        },
                        new
                        {
                            MarkId = 14,
                            DateTime = new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 95,
                            StudentId = 8,
                            SubjectId = 2
                        },
                        new
                        {
                            MarkId = 15,
                            DateTime = new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 75,
                            StudentId = 9,
                            SubjectId = 3
                        },
                        new
                        {
                            MarkId = 16,
                            DateTime = new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 90,
                            StudentId = 9,
                            SubjectId = 1
                        },
                        new
                        {
                            MarkId = 17,
                            DateTime = new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 75,
                            StudentId = 9,
                            SubjectId = 5
                        },
                        new
                        {
                            MarkId = 18,
                            DateTime = new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MarkValue = 100,
                            StudentId = 10,
                            SubjectId = 2
                        });
                });

            modelBuilder.Entity("AspNetCore2.Modles.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Jón",
                            GroupId = 3,
                            LastName = "Jónsson"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Friðrik",
                            GroupId = 2,
                            LastName = "Dór"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Jóhanna",
                            GroupId = 2,
                            LastName = "Guðrún"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "María",
                            GroupId = 1,
                            LastName = "Ólafsdóttir"
                        },
                        new
                        {
                            StudentId = 5,
                            FirstName = "Auðunn",
                            GroupId = 4,
                            LastName = "Blöndal"
                        },
                        new
                        {
                            StudentId = 6,
                            FirstName = "Steinþór",
                            GroupId = 4,
                            LastName = "Steinþórrson"
                        },
                        new
                        {
                            StudentId = 7,
                            FirstName = "Sverrir Þór",
                            GroupId = 1,
                            LastName = "Sverrirson"
                        },
                        new
                        {
                            StudentId = 8,
                            FirstName = "Ari",
                            GroupId = 3,
                            LastName = "Eldjárn"
                        },
                        new
                        {
                            StudentId = 9,
                            FirstName = "Sigga",
                            GroupId = 2,
                            LastName = "Beinteins"
                        },
                        new
                        {
                            StudentId = 10,
                            FirstName = "Selma",
                            GroupId = 3,
                            LastName = "Björnsdóttir"
                        });
                });

            modelBuilder.Entity("AspNetCore2.Modles.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            Title = "Math"
                        },
                        new
                        {
                            SubjectId = 2,
                            Title = "English"
                        },
                        new
                        {
                            SubjectId = 3,
                            Title = "History"
                        },
                        new
                        {
                            SubjectId = 4,
                            Title = "Science"
                        },
                        new
                        {
                            SubjectId = 5,
                            Title = "Computer Programming"
                        });
                });

            modelBuilder.Entity("AspNetCore2.Modles.SubjectTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectTeachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubjectId = 3,
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 2,
                            SubjectId = 5,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 3,
                            SubjectId = 1,
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 4,
                            SubjectId = 2,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 5,
                            SubjectId = 4,
                            TeacherId = 2
                        });
                });

            modelBuilder.Entity("AspNetCore2.Modles.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            FirstName = "Jakob",
                            LastName = "Frímann"
                        },
                        new
                        {
                            TeacherId = 2,
                            FirstName = "Ragnheiður",
                            LastName = "Gröndal"
                        },
                        new
                        {
                            TeacherId = 3,
                            FirstName = "Björgvin",
                            LastName = "Halldórsson"
                        });
                });

            modelBuilder.Entity("AspNetCore2.Modles.Mark", b =>
                {
                    b.HasOne("AspNetCore2.Modles.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCore2.Modles.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AspNetCore2.Modles.Student", b =>
                {
                    b.HasOne("AspNetCore2.Modles.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("AspNetCore2.Modles.SubjectTeacher", b =>
                {
                    b.HasOne("AspNetCore2.Modles.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCore2.Modles.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AspNetCore2.Modles.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AspNetCore2.Modles.Student", b =>
                {
                    b.Navigation("Marks");
                });
#pragma warning restore 612, 618
        }
    }
}
