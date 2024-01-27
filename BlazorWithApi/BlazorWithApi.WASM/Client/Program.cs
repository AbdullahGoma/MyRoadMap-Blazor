using BlazorWithApi.Share;
using BlazorWithApi.WASM;
using BlazorWithApi.WASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWithApi.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");


            // Register to HttpClient
            //builder.Services.AddScoped(
            //    sp => new HttpClient { 
            //        BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["Ip"]) 
            //    });

            //builder.Services.AddScoped<IService<Employee>, EmployeeService>();
            //builder.Services.AddScoped<IService<Department>, DepartmentService>();

            // HttpClientFactory
            builder.Services.AddHttpClient<IService<Employee>, EmployeeService>((sp, client) =>
            {
                client.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["Ip"]);
            });

            builder.Services.AddHttpClient<IService<Department>, DepartmentService>((sp, client) =>
            {
                client.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["Ip"]);
            });

            await builder.Build().RunAsync();
        }
    }
}