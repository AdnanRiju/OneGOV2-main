namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Models.OneGOV2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Models.OneGOV2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 5; i++)
            {
                context.Products.AddOrUpdate(new Models.Products
                {
                    ProductId = i,
                    Title = Guid.NewGuid().ToString().Substring(0, 15),
                    SubTittle = Guid.NewGuid().ToString().Substring(0, 15),
                    Price = i + i,
                    CategoryId = i,
                    Rating = i,
                }); ;
            }
            Random random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                context.Orders.AddOrUpdate(new Models.Orders
                {
                    OrderID = i,
                    ProductID = i,
                    UserID = i,
                    ProductName = Guid.NewGuid().ToString(),
                    Price = i,
                    Status = "User-" + random.Next(1, 11),
                });
            }
            for (int i = 1; i <= 5; i++)
            {
                context.Categories.AddOrUpdate(new Models.Categories
                {
                    CategoriID = i,
                    CategoriName = Guid.NewGuid().ToString().Substring(0, 5),

                });
            }
            for (int i = 1; i <= 5; i++)
            {
                context.UserOder.AddOrUpdate(new Models.UserOder
                {
                    OrderID = i,
                    UserOrderID = i,
                    UserID = i,
                    Price = i,
                    Decision = "User-" + random.Next(1, 11),

                });
            }
        }
    }
}
