using Microsoft.AspNetCore.Mvc;

namespace ElearnTask.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
