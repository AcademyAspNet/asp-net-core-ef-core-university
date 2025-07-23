using WebApplication9.Data;
using WebApplication9.Data.Entities;

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
    }
}
