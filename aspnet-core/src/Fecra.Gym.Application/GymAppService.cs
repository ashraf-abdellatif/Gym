using System;
using System.Collections.Generic;
using System.Text;
using Fecra.Gym.Localization;
using Volo.Abp.Application.Services;

namespace Fecra.Gym
{
    /* Inherit your application services from this class.
     */
    public abstract class GymAppService : ApplicationService
    {
        protected GymAppService()
        {
            LocalizationResource = typeof(GymResource);
        }
    }
}
