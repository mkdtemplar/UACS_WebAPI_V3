using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "student Id", "Date of Birth", "Enrollment Date", "First Name", "GPA", "Last Name", "Mail", "Student Index" },
                values: new object[] { 1, null, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kassidy", null, "Trueman", "Kassidy.Trueman@mail.com", "3516" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "student Id", "Date of Birth", "Enrollment Date", "First Name", "GPA", "Last Name", "Mail", "Student Index" },
                values: new object[] { 2, null, new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Christobel", null, "Bezuidenhout", "Christobel.Bezuidenhout@mail.com", "1241" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "student Id", "Date of Birth", "Enrollment Date", "First Name", "GPA", "Last Name", "Mail", "Student Index" },
                values: new object[] { 3, null, new DateTime(2019, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kristel", null, "Madison", "Kristel.Madison@mail.com", "3121" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "student Id", "Date of Birth", "Enrollment Date", "First Name", "GPA", "Last Name", "Mail", "Student Index" },
                values: new object[] { 4, null, new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Lyndsey", null, "Albers", "Lyndsey.Albers@mail.com", "1415" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "student Id", "Date of Birth", "Enrollment Date", "First Name", "GPA", "Last Name", "Mail", "Student Index" },
                values: new object[] { 5, null, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Alishia", null, "Gabriels", "Alishia.Gabriels@mail.com", "3717" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Address Id", "City", "Country", "Street", "StudentId" },
                values: new object[] { 1, "London", "UK", "Frying Pan Road", 1 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Address Id", "City", "Country", "Street", "StudentId" },
                values: new object[] { 2, "Cincinnati", "USA", "Error Place", 2 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Address Id", "City", "Country", "Street", "StudentId" },
                values: new object[] { 3, "Rome", "Italy", "Bad Route Road", 3 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Address Id", "City", "Country", "Street", "StudentId" },
                values: new object[] { 4, "Las Vegas", "USA", "Pillow Talk Court", 4 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Address Id", "City", "Country", "Street", "StudentId" },
                values: new object[] { 5, "Berlin", "Germany", "This Street", 5 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Exam Id", "Credits", "Name", "ProfessorName", "StudentId" },
                values: new object[] { 1, 6m, "Computer Programming", "Nicoline Abspoel", 1 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Exam Id", "Credits", "Name", "ProfessorName", "StudentId" },
                values: new object[] { 2, 5m, "Computer Architecture", "Ashlynn Van Hautum", 2 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Exam Id", "Credits", "Name", "ProfessorName", "StudentId" },
                values: new object[] { 3, 5.5m, "Databases", "Andrew Kennard", 3 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Exam Id", "Credits", "Name", "ProfessorName", "StudentId" },
                values: new object[] { 4, 5m, "Discrete Mathematics", "Algernon Aarse", 4 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Exam Id", "Credits", "Name", "ProfessorName", "StudentId" },
                values: new object[] { 5, 5m, "Data Structures and Algorithms", "Sampson Daelmans", 4 });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Exam Id", "Credits", "Name", "ProfessorName", "StudentId" },
                values: new object[] { 6, 5.5m, "Operating Systems", "Ermintrude Royceston", 5 });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 1, 1, 90m, 1, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 12, 6, 67m, 3, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 8, 6, 98m, 2, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 21, 5, 84m, 5, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 17, 5, 91m, 4, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 9, 5, 61m, 2, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 3, 5, 88m, 1, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 16, 4, 94m, 4, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 19, 3, 83m, 5, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 18, 6, 82m, 4, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 15, 3, 78m, 4, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 22, 2, 69m, 5, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 14, 2, 89m, 4, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 10, 2, 65m, 3, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 4, 2, 75m, 1, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 2, 2, 65m, 3, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 13, 1, 96m, 4, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 11, 1, 79m, 3, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 6, 1, 81m, 2, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 7, 3, 75.5m, 2, null });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Transcript Id", "ExamId", "Points", "StudentId", "transcriptId1" },
                values: new object[] { 20, 6, 78m, 5, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Address Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Address Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Address Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Address Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Address Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Transcript Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Exam Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Exam Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Exam Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Exam Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Exam Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Exam Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "student Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "student Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "student Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "student Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "student Id",
                keyValue: 5);
        }
    }
}
