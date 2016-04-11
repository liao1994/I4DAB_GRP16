namespace DAB_Handin4_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        ForNavn = c.String(nullable: false),
                        EfterNavn = c.String(nullable: false),
                        MellemNavn = c.String(),
                        Relation = c.String(nullable: false),
                        AdresseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
