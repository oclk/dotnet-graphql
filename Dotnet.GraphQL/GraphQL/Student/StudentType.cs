using GraphQL.Types;

namespace Dotnet.GraphQL.GraphQL.Student;

public class StudentType : ObjectGraphType<Entities.Student>
{
    public StudentType()
    {
        Field(x => x.Id);
        Field(x => x.Name);
        Field(x => x.Surname);
        Field(x => x.Gender);
        Field(x => x.Email);
        Field(x => x.Phone);
        Field(x => x.Address);
    }
}