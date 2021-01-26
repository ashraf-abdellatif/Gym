using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Fecra.Gym.Data
{
    /* This is used if database provider does't define
     * IGymDbSchemaMigrator implementation.
     */
    public class NullGymDbSchemaMigrator : IGymDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}