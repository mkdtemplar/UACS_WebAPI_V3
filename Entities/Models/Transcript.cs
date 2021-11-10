using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Transcript
    {
        [Column("Transcript Id")]
        [Key]
        public int transcriptId { get; set; }

        [ForeignKey(nameof(Exam))]
        public int ExamId { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        [Column("Points", TypeName = "decimal(4)")]
        public decimal Points { get; set; }

        public Student Student { get; set; }
        public Exam Exam { get; set; }
        
        public Transcript Transcripts { get; set; }
    }
}