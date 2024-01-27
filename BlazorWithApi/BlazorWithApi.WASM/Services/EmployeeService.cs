using BlazorWithApi.Share;
using System.Net.Http; // HttpClient
using System.Net.Http.Json; // Extentssion Method Http Client to work with json


namespace BlazorWithApi.WASM.Services
{
    public class EmployeeService : IService<Employee>
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient _httpClient) // Register
        {
            httpClient = _httpClient;
        }

        public async Task Add(Employee item)
        {
            await httpClient.PostAsJsonAsync<Employee>("api/Employees/", item);
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("api/Employees/" + id);
        }

        public async Task<List<Employee>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Employee>>("api/Employees");
        }

        public async Task<Employee> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>("api/Employees/" + id);
        }

        public async Task Update(int id, Employee item)
        {
            await httpClient.PutAsJsonAsync<Employee>("api/Employees/" + id, item);
        }
    }
}
