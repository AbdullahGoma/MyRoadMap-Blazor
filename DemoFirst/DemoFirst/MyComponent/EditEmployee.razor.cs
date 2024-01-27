using DemoFirst.Models;
using Microsoft.AspNetCore.Components;

namespace DemoFirst.MyComponent
{
    public partial class EditEmployee
    {
        [Parameter]
        public int Id { get; set; }
        public Employee Emp { get; set; }
        public List<Department> departments { set; get; }

        public bool DataSaved { set; get; } = false;

        [Inject]
        public NavigationManager navManager { get; set; }

        protected override void OnInitialized()
        {
            Emp = employeeService.GetEmployeeById(Id);
            departments = departmentService.GetDepartments();
            base.OnInitialized();
        }

        void Save()
        {
            Console.WriteLine("Saved" + Emp);
            DataSaved = true;
            navManager.NavigateTo("/Employee/Details/" + Id);
        }

        void Invalid()
        {
            Console.WriteLine("Invaled Object");
            DataSaved = false;
        }

    }
}
