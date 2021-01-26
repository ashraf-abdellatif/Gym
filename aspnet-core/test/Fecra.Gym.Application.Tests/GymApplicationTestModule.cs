using Volo.Abp.Modularity;

namespace Fecra.Gym
{
    [DependsOn(
        typeof(GymApplicationModule),
        typeof(GymDomainTestModule)
        )]
    public class GymApplicationTestModule : AbpModule
    {

    }
}