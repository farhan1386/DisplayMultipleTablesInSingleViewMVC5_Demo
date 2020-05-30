using DisplayMultipleTablesInSingleViewMvc_Demo.Models;
using System.Data.Entity;

namespace DisplayMultipleTablesInSingleViewMvc_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MultiTableDB")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Incentive> Incentive { get; set; }
    }
}