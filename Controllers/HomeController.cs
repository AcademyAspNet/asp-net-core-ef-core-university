using Microsoft.AspNetCore.Mvc;
using WebApplication9.Data.Entities;
using WebApplication9.Models.DTO;
using WebApplication9.Services;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;

        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Student([FromRoute] int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            Student? student = _studentService.GetStudentById((int) id);

            if (student == null)
                return RedirectToAction("Index");

            return View(student);
        }

        public IActionResult DeleteStudent([FromRoute] int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            _studentService.DeleteStudent((int) id);

            return RedirectToAction("Index");
        }

        public IActionResult NewStudent()
        {
            return View("AddStudent");
        }

        public IActionResult CreateStudent([FromForm] StudentDTO studentDto)
        {
            if (!ModelState.IsValid)
                return View("AddStudent", studentDto);

            _studentService.CreateStudent(studentDto);

            return RedirectToAction("Index");
        }
    }
}
