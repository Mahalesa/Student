using Microsoft.AspNetCore.Mvc;

namespace Student.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
