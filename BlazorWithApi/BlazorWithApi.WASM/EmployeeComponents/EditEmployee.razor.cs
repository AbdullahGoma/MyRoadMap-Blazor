using BlazorWithApi.Share;
using BlazorWithApi.WASM.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWithApi.WASM.EmployeeComponents
{
    public partial class EditEmployee
    {
        [Parameter]
        public int Id { get; set; }
        public Employee employee { get; set; }
        public List<Department> departments { set; get; }
        [Inject]
        public NavigationManager navManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            employee = await EmployeeService.GetById(Id);
            departments = await departmentService.GetAll();
            await base.OnInitializedAsync();
        }

        public async void Save()
        {
            await EmployeeService.Update(Id, employee);
            navManager.NavigateTo("/Employee/Details/" + Id);
        }

        void Invalid()
        {
            Console.WriteLine("Invaled Object");
        }
    }
}
