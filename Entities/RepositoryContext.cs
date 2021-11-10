using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TranscriptConfiguration());
        }
        
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Address> Addresses { get; set; }
        public  DbSet<Exam> Exams { get; set; }
        public  DbSet<Transcript> Transcripts { get; set; }
        
    }
}