using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Address
    {
        [Column("Address Id")]
        [Key]
        public int AddressId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
        
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        
        public Student Student { get; set; }
    }
}