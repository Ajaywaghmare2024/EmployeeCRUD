using EmployeeCRUD.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repo;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IEmployeeRepository repo, ILogger<EmployeeController> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var empList = _repo.GetAll();
            _logger.LogInformation("List of Employee",empList);
            return View(empList);
        }
        public IActionResult GetByEmpById(int empId)
        {
            var emp = _repo.GetEmployeeById(empId);
            return View(emp);
        }
    }
}
