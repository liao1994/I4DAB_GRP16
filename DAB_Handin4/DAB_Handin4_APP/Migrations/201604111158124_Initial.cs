namespace DAB_Handin4_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        AdressID = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        Town = c.String(nullable: false),
                        ZipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdressID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.Int(nullable: false),
                        CountryCode = c.Int(nullable: false),
                        PhoneType = c.String(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phones");
            DropTable("dbo.Adresses");
        }
    }
}
