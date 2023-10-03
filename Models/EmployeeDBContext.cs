using Microsoft.EntityFrameworkCore;

namespace Employee_TaskCoreWebApis.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext (DbContextOptions<EmployeeDBContext>options):base(options)
        {

        }
        public DbSet<TblEmployees> Employees { get; set; }
    }
}
