using Microsoft.AspNetCore.Mvc;

using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        List<Employee> employees = new List<Employee>()
            {
                new Employee(){ empId = 1, name ="User1",department="R&D" },
                new Employee(){ empId = 2, name ="User2",department="Testing" },
                new Employee(){ empId = 3, name ="User3",department="Development" }
            };
        [Route("")]
        public IActionResult Index()
        {

            return View(employees);
        }


        [Route("Add")]
        public IActionResult AddForm()
        {
            return View();
        }
        [Route("AddEmployee")]
        public IActionResult AddEmployee(int empid, string name, string department)
        {
            employees.Add(new() { empId = empid, name = name, department = department });

            return View(employees);
        }
    }
}
