using Microsoft.EntityFrameworkCore;
using WebApplication9.Data;
using WebApplication9.Data.Entities;
using WebApplication9.Models.DTO;

namespace WebApplication9.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _database;

        public StudentService(ApplicationDbContext database)
        {
            _database = database;
        }

        public IList<Student> GetStudents()
        {
            return _database.Students.ToList();
        }

        public Student? GetStudentById(int id)
        {
            return _database.Students.Find(id);
        }

        public void DeleteStudent(int id)
        {
            //Student? student = _database.Students.Find(id);

            //if (student == null)
            //    return;

            //_database.Remove(student);
            //_database.SaveChanges();

            _database.Students.Where(s => s.Id == id).ExecuteDelete();
        }

        public void CreateStudent(StudentDTO studentDto)
        {
            Student student = new Student()
            {
                FirstName = studentDto.FirstName!,
                LastName = studentDto.LastName!,
                Email = studentDto.Email!
            };

            _database.Students.Add(student);
            _database.SaveChanges();
        }
    }
}
