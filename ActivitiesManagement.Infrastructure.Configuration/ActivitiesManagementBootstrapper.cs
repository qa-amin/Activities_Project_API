using ActivitiesManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ActivitiesManagement.Infrastructure.Configuration
{
    public class ActivitiesManagementBootstrapper
    {
        public static void Config(IServiceCollection services, string cs)
        {
            services.AddDbContext<ActivitiesContext>(x => x.UseSqlServer(cs));
        }
    }
}
