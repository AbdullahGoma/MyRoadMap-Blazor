using BlazorWithApi.Share;
using System.Net.Http; // HttpClient
using System.Net.Http.Json; // Extentssion Method Http Client to work with json

namespace BlazorWithApi.WASM.Services
{
    public class DepartmentService : IService<Department>
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient _httpClient) // Register
        {
            httpClient = _httpClient;
        }


        public async Task Add(Department item)
        {
            await httpClient.PostAsJsonAsync<Department>("api/Departments/", item);
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("api/Departments/" + id);
        }

        public async Task<List<Department>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Department>>("api/Departments");
        }

        public async Task<Department> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Department>("api/Departments/" + id);
        }

        public async Task Update(int id, Department item)
        {
            await httpClient.PutAsJsonAsync<Department>("api/Departments/" + id, item);
        }
    }
}
