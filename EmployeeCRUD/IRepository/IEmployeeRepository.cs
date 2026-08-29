using EmployeeCRUD.Models;

namespace EmployeeCRUD.IRepository
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetEmployeeById(int id);
       Task<List<Employee>> GetAll();
    }
}
