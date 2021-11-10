using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);

        Student GetSingleStudent(int studentId, bool trackChanges);

        void CreateStudent(Student student);

        void DeleteStudent(Student student);
    }
}