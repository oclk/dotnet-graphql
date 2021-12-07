using Dotnet.GraphQL.Entities;

namespace Dotnet.GraphQL.Infrastructure.Repositories.Interfaces;

public interface IStudentRepository
{
    List<Student> GetStudents();
}