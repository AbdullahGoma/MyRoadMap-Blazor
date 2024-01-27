using DemoFirst.Models;

namespace DemoFirst.Data
{
    public class EmployeeData
    {
        List<Employee> Employees { set; get; } = new List<Employee>();
        public EmployeeData()
        {
            Employees.Add(new Employee { ID = 1, Name = "Abdullah", Salary = 150000, Img = "/Imges/1.png", DepartmentID = 2 });
            Employees.Add(new Employee { ID = 2, Name = "Ali", Salary = 15000, Img = "/Imges/2.png", DepartmentID = 1 });
            Employees.Add(new Employee { ID = 3, Name = "Mohammed", Salary = 16000, Img = "/Imges/3.png", DepartmentID = 3 });
            Employees.Add(new Employee { ID = 4, Name = "Mahmoud", Salary = 14000, Img = "/Imges/4.png", DepartmentID = 4 });
            Employees.Add(new Employee { ID = 5, Name = "Kasem", Salary = 17000, Img = "/Imges/5.png", DepartmentID = 2 });
        }
        public List<Employee> GetEmployees()
        {
            return Employees;
        }
    }
}
