using GraphQL.Types;

namespace Dotnet.GraphQL.GraphQL.Student;

public class StudentSchema : Schema
{
    public StudentSchema(IServiceProvider serviceProvider): base(serviceProvider)
    {
        Query = serviceProvider.GetService<StudentQuery>();
    }
}