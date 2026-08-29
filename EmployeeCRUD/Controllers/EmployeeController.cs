using EmployeeCRUD.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var empList = _repo.GetAll();
            return View(empList);
        }
        public IActionResult GetByEmpById(int empId)
        {
            var emp = _repo.GetEmployeeById(empId);
            return View(emp);
        }
    }
}
