using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Student
    {
        [Column("student Id")]
        [Key]
        public int studentId { get; set; }

        [Column("First Name", TypeName = "nvarchar(200)")]
        public string FirstName { get; set; }

        [Column("Last Name", TypeName = "nvarchar(200)")]
        public string LastName { get; set; }

        [Column("Enrollment Date", TypeName = "datetime")]
        public DateTime? EnrollmentDate { get; set; }

        [Column("Date of Birth", TypeName = "datetime")]
        public DateTime? DOB { get; set; }

        public string Mail { get; set; }

        [Column("Student Index", TypeName = "char(4)")]
        public string StudentIndex { get; set; }

        [Column("GPA", TypeName = "decimal(3,2)")]
        public decimal? GPA { get; set; }
        
        public  ICollection<Address> Addresses { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }
}