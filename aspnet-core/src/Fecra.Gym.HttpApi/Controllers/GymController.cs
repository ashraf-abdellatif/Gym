using Fecra.Gym.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Fecra.Gym.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class GymController : AbpController
    {
        protected GymController()
        {
            LocalizationResource = typeof(GymResource);
        }
    }
}