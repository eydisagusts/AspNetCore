using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCore2.Migrations
{
    /// <inheritdoc />
    public partial class InformationAddedToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name" },
                values: new object[,]
                {
                    { 1, "Blue" },
                    { 2, "Red" },
                    { 3, "Green" },
                    { 4, "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Title" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "English" },
                    { 3, "History" },
                    { 4, "Science" },
                    { 5, "Computer Programming" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Jakob", "Frímann" },
                    { 2, "Ragnheiður", "Gröndal" },
                    { 3, "Björgvin", "Halldórsson" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1, "Jón", 3, "Jónsson" },
                    { 2, "Friðrik", 2, "Dór" },
                    { 3, "Jóhanna", 2, "Guðrún" },
                    { 4, "María", 1, "Ólafsdóttir" },
                    { 5, "Auðunn", 4, "Blöndal" },
                    { 6, "Steinþór", 4, "Steinþórrson" },
                    { 7, "Sverrir Þór", 1, "Sverrirson" },
                    { 8, "Ari", 3, "Eldjárn" },
                    { 9, "Sigga", 2, "Beinteins" },
                    { 10, "Selma", 3, "Björnsdóttir" }
                });

            migrationBuilder.InsertData(
                table: "SubjectTeachers",
                columns: new[] { "Id", "SubjectId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 3, 2 },
                    { 2, 5, 1 },
                    { 3, 1, 3 },
                    { 4, 2, 1 },
                    { 5, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "MarkId", "DateTime", "MarkValue", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 1, 2 },
                    { 2, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 1, 1 },
                    { 3, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 2, 4 },
                    { 4, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 2, 5 },
                    { 5, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 3, 2 },
                    { 6, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 3, 4 },
                    { 7, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 4, 1 },
                    { 8, new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 4, 5 },
                    { 9, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 5, 3 },
                    { 10, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 5, 2 },
                    { 11, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 6, 4 },
                    { 12, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 6, 1 },
                    { 13, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 7, 5 },
                    { 14, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 8, 2 },
                    { 15, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 9, 3 },
                    { 16, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 9, 1 },
                    { 17, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 9, 5 },
                    { 18, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 10, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "MarkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4);
        }
    }
}
