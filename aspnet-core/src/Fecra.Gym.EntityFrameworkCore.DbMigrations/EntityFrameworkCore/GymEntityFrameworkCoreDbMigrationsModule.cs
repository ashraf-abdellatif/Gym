using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Fecra.Gym.EntityFrameworkCore
{
    [DependsOn(
        typeof(GymEntityFrameworkCoreModule)
        )]
    public class GymEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GymMigrationsDbContext>();
        }
    }
}
