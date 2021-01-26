using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Fecra.Gym.EntityFrameworkCore
{
    public static class GymDbContextModelCreatingExtensions
    {
        public static void ConfigureGym(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(GymConsts.DbTablePrefix + "YourEntities", GymConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}