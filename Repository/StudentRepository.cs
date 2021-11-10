using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.FirstName).Include(a => a.Addresses).Include(e => e.Exams).ToList();

        public Student GetSingleStudent(int studentId, bool trackChanges) =>
            FindByCondition(c => c.studentId.Equals(studentId), trackChanges).Include(a => a.Addresses).Include(e => e.Exams).SingleOrDefault();

        public void CreateStudent(Student student) =>
            Create(student);

        public void DeleteStudent(Student student)
        {
            Delete(student);
        }
    }
}