using BlazorWithApi.Share;

namespace BlazorWithApi.WASM.EmployeeComponents
{
    public partial class GetAllEmployee
    {
        public List<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            // Get Employee From Services
            Employees = await EmployeeService.GetAll();
            await base.OnInitializedAsync();
        }
    }
}
