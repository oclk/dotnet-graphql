using Microsoft.AspNetCore.Mvc;

namespace Dotnet.GraphQL.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpPost("get-students")]
    public IActionResult GetStudents()
    {
        return Ok();
    }
}