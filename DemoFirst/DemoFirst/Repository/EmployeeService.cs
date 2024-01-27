using DemoFirst.Data;
using DemoFirst.Models;

namespace DemoFirst.Repository
{
    public class EmployeeService
    {
        EmployeeData EmployeeData;
        public EmployeeService()
        {
            EmployeeData = new EmployeeData();
        }

        public List<Employee> GetEmployees()
        {
            return EmployeeData.GetEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return EmployeeData.GetEmployees().FirstOrDefault(e => e.ID == id);
        }


    }
}
