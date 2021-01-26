using System.Threading.Tasks;

namespace Fecra.Gym.Data
{
    public interface IGymDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
