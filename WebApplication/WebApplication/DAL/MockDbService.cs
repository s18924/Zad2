using System.Collections;
using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;
        
        static MockDbService()
        {
            _students = new List<Student>()
            {
                new Student()
                {
                    IdStudent = 1,
                    FirstName = "Szymek",
                    LastName = "P",
                    IndexNumber = "s18924"
                },
                new Student()
                {
                    IdStudent = 2,
                    FirstName = "Szymekkllk",
                    LastName = "P",
                    IndexNumber = "s18928"
                },     new Student()
                {
                    IdStudent = 5,
                    FirstName = "Simi",
                    LastName = "OpopopP",
                    IndexNumber = "s11924"
                }
            };

        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}