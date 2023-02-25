using System.Data.Entity.Migrations;

namespace Eeoe.Restaurant.DataAccess.Contexts.Restaurant
{
    public class RestaurantConfiguration : DbMigrationsConfiguration<RestaurantContext>
    {
        public RestaurantConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed=true;
        }
    }
}