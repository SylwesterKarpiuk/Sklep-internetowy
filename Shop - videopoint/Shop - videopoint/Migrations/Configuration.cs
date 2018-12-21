namespace Shop___videopoint.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop___videopoint.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Shop___videopoint.Models.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.Name, new Models.Category { Name = "Kategoria g³ówna" }, new Models.Category { Name = "Elektronika" });
        }
    }
}
