using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.UI.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
