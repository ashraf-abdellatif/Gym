using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Fecra.Gym
{
    [Dependency(ReplaceServices = true)]
    public class GymBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Gym";
    }
}
