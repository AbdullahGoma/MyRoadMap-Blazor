using DemoFirst.Data;
using DemoFirst.Models;

namespace DemoFirst.Repository
{
    public class DepartmentService
    {
        DepartmentData DepartmentData;
        public DepartmentService()
        {
            DepartmentData = new DepartmentData();
        }
        

        public List<Department> GetDepartments()
        {
            return DepartmentData.GetDepartments();
        }  

        public Department GetDepartmentById(int id)
        {
            return DepartmentData.GetDepartments().FirstOrDefault(d => d.ID == id);
        }

    }
}
