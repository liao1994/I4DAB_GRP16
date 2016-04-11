using System.Web.WebPages;
using DAB_Handin4_APP.Models;

namespace DAB_Handin4_APP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAB_Handin4_APP.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DAB_Handin4_APP.Models.DAB_Handin4_APPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAB_Handin4_APP.Models.DAB_Handin4_APPContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.People.AddOrUpdate(
                x => x.PersonID,
                new Person() {ForNavn = "test",EfterNavn = "testersen",Relation = "N/A INFO"});
     

   
        }
    }
}
