using Microsoft.AspNetCore.Mvc;

namespace FileTrackingSystem.Controllers
{
    public class InwardOutwardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FromTo()
        {
            return View();
        }
        public IActionResult SubjectMaster()
        {
            return View();
        }
        public IActionResult DepartmentMaster()
        {
            return View();
        }
        public IActionResult LetterType()
        {
            return View();
        }
        public IActionResult StatusMaster()
        {
            return View();
        }
    }
}
