using BlazorWithApi.Share;
using Microsoft.EntityFrameworkCore;

namespace BlazorWithApi.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
