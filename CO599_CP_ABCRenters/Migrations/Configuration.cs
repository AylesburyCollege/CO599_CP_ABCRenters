namespace CO599_CP_ABCRenters.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CO599_CP_ABCRenters.Models.PropertyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CO599_CP_ABCRenters.Models.PropertyDbContext";
        }

        protected override void Seed(CO599_CP_ABCRenters.Models.PropertyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
