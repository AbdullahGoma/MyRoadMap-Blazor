using BlazorWithApi.Share;
using Microsoft.AspNetCore.Components;

namespace BlazorWithApi.WASM.EmployeeComponents
{
    public partial class DetailsEmployee
    {
        [Parameter]
        public int Id { get; set; }
        public Employee employee { get; set; }

        protected override async Task OnInitializedAsync()
        {
            employee = await EmployeeService.GetById(Id);
            await base.OnInitializedAsync();
        }
    }
}
