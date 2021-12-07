using Dotnet.GraphQL.Infrastructure.Repositories.Interfaces;
using GraphQL;
using GraphQL.Types;

namespace Dotnet.GraphQL.GraphQL.Student;

public class StudentQuery : ObjectGraphType
{
    public StudentQuery(IStudentRepository studentRepository)
    {
        Field<ListGraphType<StudentType>>(Name = "students", resolve: x => studentRepository.GetStudents());
        Field<StudentType>(Name = "student", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }), resolve: x => studentRepository.GetStudents().FirstOrDefault(p => p.Id == x.GetArgument<int>("id")));
    }
}