using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EmployeeServiceWebApiDemo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Employees> Employeeses { get; set; }

        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}