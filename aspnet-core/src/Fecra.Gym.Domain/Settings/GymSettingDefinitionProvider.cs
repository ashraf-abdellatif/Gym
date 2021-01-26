using Volo.Abp.Settings;

namespace Fecra.Gym.Settings
{
    public class GymSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(GymSettings.MySetting1));
        }
    }
}
