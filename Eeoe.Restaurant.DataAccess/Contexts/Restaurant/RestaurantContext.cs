using System.Data.Entity;
using Eeoe.Restaurant.DataAccess.Contexts.Base;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Contexts.Restaurant
{
    public class RestaurantContext : BaseContext<RestaurantContext>
    {
        public RestaurantContext()
        {

        }

        public RestaurantContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantContext,RestaurantConfiguration>());
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<EkMalzeme> EkMalzemeler { get; set; }
    }
}