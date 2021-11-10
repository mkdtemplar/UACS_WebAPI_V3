using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class TranscriptConfiguration : IEntityTypeConfiguration<Transcript>
    {
        public void Configure(EntityTypeBuilder<Transcript> builder)
        {
             builder.HasData(
                    new Transcript
                {
                    transcriptId = 1,
                    ExamId = 1,
                    StudentId = 1,
                    Points = 90
                },
                new Transcript
                {
                    transcriptId = 3,
                    ExamId = 5,
                    StudentId = 1,
                    Points = 88
                },
                new Transcript
                {
                    transcriptId = 2,
                    ExamId = 2,
                    StudentId = 3,
                    Points = 65
                },
                new Transcript
                {
                    transcriptId = 4,
                    ExamId = 2,
                    StudentId = 1,
                    Points = 75
                },
                new Transcript
                {
                    transcriptId = 6,
                    ExamId = 1,
                    StudentId = 2,
                    Points = 81
                },
                new Transcript
                {
                    transcriptId = 7,
                    ExamId = 3,
                    StudentId = 2,
                    Points = (decimal) 75.5
                },
                new Transcript
                {
                    transcriptId = 8,
                    ExamId = 6,
                    StudentId = 2,
                    Points = 98
                },
                new Transcript
                {
                    transcriptId = 9,
                    ExamId = 5,
                    StudentId = 2,
                    Points = 61
                },
                new Transcript
                {
                    transcriptId = 10,
                    ExamId = 2,
                    StudentId = 3,
                    Points = 65
                },
                new Transcript
                {
                    transcriptId = 11,
                    ExamId = 1,
                    StudentId = 3,
                    Points = 79
                },
                new Transcript
                {
                    transcriptId = 12,
                    ExamId = 6,
                    StudentId = 3,
                    Points = 67
                },
                new Transcript
                {
                    transcriptId = 13,
                    ExamId = 1,
                    StudentId = 4,
                    Points = 96
                },
                new Transcript
                {
                    transcriptId = 14,
                    ExamId = 2,
                    StudentId = 4,
                    Points = 89
                },
                new Transcript
                {
                    transcriptId = 15,
                    ExamId = 3,
                    StudentId = 4,
                    Points = 78
                },
                new Transcript
                {
                    transcriptId = 16,
                    ExamId = 4,
                    StudentId = 4,
                    Points = 94
                },
                new Transcript
                {
                    transcriptId = 17,
                    ExamId = 5,
                    StudentId = 4,
                    Points = 91
                },
                new Transcript
                {
                    transcriptId = 18,
                    ExamId = 6,
                    StudentId = 4,
                    Points = 82
                },
                new Transcript
                {
                    transcriptId = 19,
                    ExamId = 3,
                    StudentId = 5,
                    Points = 83
                },
                new Transcript
                {
                    transcriptId = 20,
                    ExamId = 6,
                    StudentId = 5,
                    Points = 78
                },
                new Transcript
                {
                    transcriptId = 21,
                    ExamId = 5,
                    StudentId = 5,
                    Points = 84
                },
                new Transcript
                {
                    transcriptId = 22,
                    ExamId = 2,
                    StudentId = 5,
                    Points = 69
                }
                );
        }
    }
}