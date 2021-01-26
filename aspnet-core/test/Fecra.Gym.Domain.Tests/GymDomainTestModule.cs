using Fecra.Gym.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Fecra.Gym
{
    [DependsOn(
        typeof(GymEntityFrameworkCoreTestModule)
        )]
    public class GymDomainTestModule : AbpModule
    {

    }
}