using Dotnet.GraphQL.Entities;
using Dotnet.GraphQL.Infrastructure.Repositories.Interfaces;

namespace Dotnet.GraphQL.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    public List<Student> GetStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 0 , Name = "Charlie", Surname = "Wilkinson", Gender = "male", Email = "charlie.wilkinson@outlook.com", Phone = "+1 877-925-4167", Address = "Texas - United States of America" },
            new Student { Id = 0 , Name = "Jessica", Surname = "Atkinson", Gender = "female", Email = "jessica.atkinson@gmail.com", Phone = "+1 877-999-3409", Address = "Florida - United States of America" },
            new Student { Id = 0 , Name = "Harry", Surname = "Bailey", Gender = "male", Email = "harry.bailey@outlook.com", Phone = "+1 877-345-1213", Address = "Montana - United States of America" },
            new Student { Id = 0 , Name = "Sophie", Surname = "Saunders", Gender = "female", Email = "sophie.saunders@gmail.com", Phone = "+1 877-487-1098", Address = "Washington - United States of America" },
        };

        return students;
    }
}