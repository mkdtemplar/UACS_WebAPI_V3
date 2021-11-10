using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ExamDto
    {
        
        public int examId { get; set; }

        public string Name { get; set; }
        public string ProfessorName { get; set; }

        public decimal Credits { get; set; }

        public int StudentId { get; set; }
    }
}
