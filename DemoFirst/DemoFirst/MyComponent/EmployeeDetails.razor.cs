using DemoFirst.Models;
using Microsoft.AspNetCore.Components;

namespace DemoFirst.MyComponent
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public int Id { get; set; }
        public Employee Employee { get; set; } = new Employee();

        // First Call
        public EmployeeDetails()
        {
            Console.WriteLine("Constructor: " + Id);
        }
        // Third Call 
        protected override void OnParametersSet()
        {
            Console.WriteLine("OnParametersSet: " + Id);
            base.OnParametersSet();
        }
        //  Second Call 
        protected override void OnInitialized()
        {
            Console.WriteLine("OnInitialized: " + Id);
            // EmployeeService employeeService = new EmployeeService();
            Employee = employeeService.GetEmployeeById(Id);
            base.OnInitialized();
        }
    }
}
