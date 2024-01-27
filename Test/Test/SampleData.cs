using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class SampleData
    {

        private List<Department> _departments;
        public List<Department> Departments { get; private set; }

        private List<Student> _students;
        public List<Student> Students { get; private set; }

        public SampleData()
        {
            Departments = new List<Department>()
                    {
                        new Department { ID = 1, Name = "Social Media" },
                        new Department { ID = 2, Name = "Engineers" },
                        new Department { ID = 3, Name = "Web" }
                    };

            Students = new List<Student>()
                    {
                        new Student { ID = 1, Name = "Abdullah", Address = "Dakahlia", DepartmentID = 2 },
                        new Student { ID = 2, Name = "Ali", Address = "Dakahlia", DepartmentID = 1 },
                        new Student { ID = 3, Name = "Mohammed", Address = "Dakahlia", DepartmentID = 3 },
                        new Student { ID = 4, Name = "Mahmoud", Address = "Dakahlia", DepartmentID = 2 },
                        new Student { ID = 5, Name = "Kasem", Address = "Dakahlia", DepartmentID = 1 },
                        new Student { ID = 6, Name = "Ibrahem", Address = "Dakahlia", DepartmentID = 2 }
                    };
        }


        public List<Student> GetStudents() => Students;

        public List<Department> GetDepartments() => Departments;



    }
}
