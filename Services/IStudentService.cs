using WebApplication9.Data.Entities;

namespace WebApplication9.Services
{
    public interface IStudentService
    {
        IList<Student> GetStudents();
    }
}
