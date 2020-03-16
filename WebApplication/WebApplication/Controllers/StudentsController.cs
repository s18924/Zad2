using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DAL;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        // GET
        /*[HttpGet("{id}")]
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
        }*/
        /*[HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Kowalski, Malloy, Martin sortowanie={orderBy}";

        }*/

        [HttpPost]
        public IActionResult CreateStudents(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult putString(int id)
        {
            if (id==2)
            {
                Console.Write(id);
                return Ok("Zaktualizowany Kowalski");
            }
            else if (id==1)
            {
                Console.Write(id);
                return Ok("Zaktualizowany Malewski");
            }
            else
            {
                return Ok("Tralalalal");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult deleteString(int id)
        {
            if (id==2)
            {
                Console.Write(id);
                return Ok("Usunięty Kowalski");
            }
            else if (id==1)
            {
                Console.Write(id);
                return Ok("Usunięty Malewski");
            }
            else
            {
                return Ok("Tralalalal");
            }
        }
        
    }
}  