using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        // GET
        [HttpGet("{id}")]
        public string GetStudent(int id)
        {
            if(id==1)
                
                return "Kowalski, Malloy, Martin";
            else if (id == 2)
                return "Kozakowski";
            else
            {
                return "Nie ma takiego";
            }
        }
    }
}  