namespace EmployeeCRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }
        public int Age { get; set; }
        public DateOnly JoinDate { get; set; }
        public string Department { get; set; }


    }
}
