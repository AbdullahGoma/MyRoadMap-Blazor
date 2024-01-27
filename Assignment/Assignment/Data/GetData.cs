using Assignment.Models;

namespace Assignment.Data
{
    public class GetData
    {
        public SampleData SampleData;
        public GetData()
        {
            SampleData = new SampleData();
        }

        public List<Student> GetStudentByDepartmentID(int DepartmentID)
        {
            List<Student> students = new List<Student>();
            foreach (Student student in SampleData.GetStudents())
            {
                if (student.DepartmentID == DepartmentID)
                    students.Add(student);
            }
            return students;
        }

        public List<Department> GetDepartments() => SampleData.GetDepartments();

        public List<Student> GetStudents() => SampleData.GetStudents();

    }
}
