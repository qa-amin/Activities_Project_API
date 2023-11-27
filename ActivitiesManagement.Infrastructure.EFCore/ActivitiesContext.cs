using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace ActivitiesManagement.Infrastructure.EFCore
{
    public class ActivitiesContext : DbContext
    {
        public ActivitiesContext(DbContextOptions<ActivitiesContext> options):base(options)
        {
            
        }

        public DbSet<Activity> Activities {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
