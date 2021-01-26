using Fecra.Gym.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Fecra.Gym.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(GymEntityFrameworkCoreDbMigrationsModule),
        typeof(GymApplicationContractsModule)
        )]
    public class GymDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
