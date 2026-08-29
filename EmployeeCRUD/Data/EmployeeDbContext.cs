using EmployeeCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data
{
    public class EmployeeDbContext :DbContext
    {
        public EmployeeDbContext(DbContextOptions options) :base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
