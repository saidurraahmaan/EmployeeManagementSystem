using EmployeeManagement.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApi.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee()
        {

            //return Json(new { EmployeeId = 1 });
        }
    }
}
