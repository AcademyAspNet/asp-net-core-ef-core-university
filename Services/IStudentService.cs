using WebApplication9.Data.Entities;
using WebApplication9.Models.DTO;

namespace WebApplication9.Services
{
    public interface IStudentService
    {
        IList<Student> GetStudents();
        Student? GetStudentById(int id);
        void DeleteStudent(int id);
        void CreateStudent(StudentDTO studentDto);
    }
}
