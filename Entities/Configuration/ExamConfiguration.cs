using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasData(
                new Exam {examId = 1, Name = "Computer Programming", ProfessorName = "Nicoline Abspoel", Credits = 6, StudentId = 1},
                new Exam {examId = 2, Name = "Computer Architecture", ProfessorName = "Ashlynn Van Hautum", Credits = 5, StudentId = 2},
                new Exam {examId = 3, Name = "Databases", ProfessorName = "Andrew Kennard", Credits = new decimal(5.5), StudentId = 3},
                new Exam {examId = 4, Name = "Discrete Mathematics", ProfessorName = "Algernon Aarse", Credits = 5, StudentId = 4},
                new Exam
                {
                    examId = 5, Name = "Data Structures and Algorithms", ProfessorName = "Sampson Daelmans", Credits = 5, StudentId = 4
                },
                new Exam
                {
                    examId = 6, Name = "Operating Systems", ProfessorName = "Ermintrude Royceston", Credits = new decimal(5.5), StudentId = 5
                }
            );
        }
    }
}