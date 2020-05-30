namespace DisplayMultipleTablesInSingleViewMvc_Demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DisplayMultipleTablesInSingleViewMvc_Demo.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DisplayMultipleTablesInSingleViewMvc_Demo.Data.ApplicationDbContext";
        }

        protected override void Seed(DisplayMultipleTablesInSingleViewMvc_Demo.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
