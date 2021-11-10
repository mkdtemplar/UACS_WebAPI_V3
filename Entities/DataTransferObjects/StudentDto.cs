using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.DataTransferObjects
{
    public class StudentDto
    {
       
        public int studentId { get; set; }

       
        public string FullName { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public DateTime? DOB { get; set; }

        public string Mail { get; set; }

        public string StudentIndex { get; set; }

        public decimal? GPA { get; set; }

        public ICollection<AddressDto>  Addresses { get; set; }
        public ICollection<ExamDto> ExamDtos { get; set; }
    }
}
