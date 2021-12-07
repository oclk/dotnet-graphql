using Dotnet.GraphQL.GraphQL.Student;
using Dotnet.GraphQL.Infrastructure.Repositories;
using Dotnet.GraphQL.Infrastructure.Repositories.Interfaces;
using GraphQL.Server;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<StudentType>();
builder.Services.AddSingleton<StudentQuery>();
builder.Services.AddSingleton<ISchema, StudentSchema>();
builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
builder.Services.AddGraphQL(opt => opt.EnableMetrics = false).AddSystemTextJson();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseGraphQLAltair();
app.UseGraphQL<ISchema>();

app.Run();
