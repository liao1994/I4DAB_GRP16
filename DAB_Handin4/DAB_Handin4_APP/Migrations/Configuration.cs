<<<<<<< HEAD
using System.Web.WebPages;
using DAB_Handin4_APP.Models;
=======
using DAB_Handin4_APP.Models;
using DbMigration = System.Data.Entity.Migrations.DbMigration;
using DbMigrationsConfiguration = System.Data.Entity.Migrations.DbMigrationsConfiguration;
>>>>>>> origin/master

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

<<<<<<< HEAD
            context.People.AddOrUpdate(
                x => x.PersonID,
                new Person() {ForNavn = "test",EfterNavn = "testersen",Relation = "N/A INFO"});
     

   
=======
            {
                context.Adresses.AddOrUpdate(x => x.AdressID,
                    new Adresse() { AdressID = 1, StreetName = "Finlandsgade",  StreetNumber = 22, Town = "Aarhus", ZipCode = 8210, Country = "Denmark" },
                    new Adresse() { AdressID = 2, StreetName = "Katrinebjergvej", StreetNumber = 10, Town = "Aarhus", ZipCode = 8210, Country = "Denmark" },
                    new Adresse() { AdressID = 3, StreetName = "Langelandsgade", StreetNumber = 189, Town = "Aarhus", ZipCode = 8210, Country = "Denmark" }
                    );

                context.Phones.AddOrUpdate(x => x.PhoneID,
                    new Phone() {PhoneID = 1, PhoneNumber = 12345678, CountryCode = 45, PhoneType = "Mobil", PersonID = 1},
                    new Phone() { PhoneID = 2, PhoneNumber = 87654321, CountryCode = 45, PhoneType = "Mobil", PersonID = 2 },
                    new Phone() { PhoneID = 3, PhoneNumber = 88888888, CountryCode = 45, PhoneType = "Mobil", PersonID = 3 }

                    );

            }
>>>>>>> origin/master
        }
    }
}
