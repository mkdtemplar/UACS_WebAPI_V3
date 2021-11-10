using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Exam
    {
        [Column("Exam Id")]
        [Key]
        public int examId { get; set; }

        public string Name { get; set; }
        public string ProfessorName { get; set; }
        
        [Column("Credits", TypeName = "decimal(4)")]
        public decimal Credits { get; set; }
        
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        
        public Student Student { get; set; }
    }
}