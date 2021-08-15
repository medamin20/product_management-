namespace GP.Data.Migrations
{
    using GP.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GP.Data.GPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GP.Data.GPContext";
        }

        protected override void Seed(GP.Data.GPContext context)
        {

            context.Categories.AddOrUpdate(

            p => p.Name, //Uniqueness property
            new Category { Name = "Medicament" },
            new Category { Name = "Vetement" },
            new Category { Name = "Meuble" }
                );
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
