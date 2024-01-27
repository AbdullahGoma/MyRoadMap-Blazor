using DemoFirst.Models;

namespace DemoFirst.Data
{
    public class DepartmentData
    {
        List<Department> Departments { set; get; } = new List<Department>();
        public DepartmentData()
        {
            Departments.Add(new Department { ID = 1, Name = "SD"});
            Departments.Add(new Department { ID = 2, Name = "Web & Mobile" });
            Departments.Add(new Department { ID = 3, Name = "2D" });
            Departments.Add(new Department { ID = 4, Name = "Digital Marketing" });
        }
        public List<Department> GetDepartments()
        {
            return Departments;
        }
    }
}
