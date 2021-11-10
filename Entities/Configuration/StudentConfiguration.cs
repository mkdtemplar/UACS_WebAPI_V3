using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
     public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(new Student
                {
                    studentId = 1,
                    FirstName = "Kassidy",
                    LastName = "Trueman",
                    StudentIndex = "3516",
                    Mail = "Kassidy.Trueman@mail.com",
                    EnrollmentDate = DateTime.Today.AddYears(-3)
                },
                new Student
                {
                    studentId = 2,
                    FirstName = "Christobel",
                    LastName = "Bezuidenhout",
                    StudentIndex = "1241",
                    Mail = "Christobel.Bezuidenhout@mail.com",
                    EnrollmentDate = DateTime.Today.AddYears(-4)
                },
                new Student
                {
                    studentId = 3,
                    FirstName = "Kristel",
                    LastName = "Madison",
                    StudentIndex = "3121",
                    Mail = "Kristel.Madison@mail.com",
                    EnrollmentDate = DateTime.Today.AddYears(-2)
                },
                new Student
                {
                    studentId = 4,
                    FirstName = "Lyndsey",
                    LastName = "Albers",
                    StudentIndex = "1415",
                    Mail = "Lyndsey.Albers@mail.com",
                    EnrollmentDate = DateTime.Today.AddYears(-1)
                },
                new Student
                {
                    studentId = 5,
                    FirstName = "Alishia",
                    LastName = "Gabriels",
                    StudentIndex = "3717",
                    Mail = "Alishia.Gabriels@mail.com",
                    EnrollmentDate = DateTime.Today.AddYears(-3)
                
                });
        }
    }
}