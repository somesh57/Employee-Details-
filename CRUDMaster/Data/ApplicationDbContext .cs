using CRUDMaster.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMaster.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
