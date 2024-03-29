namespace MVCTutorial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCTutorial.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCTutorial.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(p => p.ProductID,
                new Products
                {
                    ProductID = 1,
                    Description = "TV",
                    Brand = "Samsung",
                    Quantity = 1,
                    Price = 500,
                },
                new Products
                {
                    ProductID = 2,
                    Description = "M�vil",
                    Brand = "Apple",
                    Quantity = 1,
                    Price = 600,
                }
           );
        }
    }
}
