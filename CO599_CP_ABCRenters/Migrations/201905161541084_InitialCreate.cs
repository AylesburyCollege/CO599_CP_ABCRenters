namespace CO599_CP_ABCRenters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        House = c.String(nullable: false, maxLength: 30),
                        StreetName = c.String(maxLength: 30),
                        TownName = c.String(nullable: false, maxLength: 30),
                        Postcode = c.String(nullable: false, maxLength: 10),
                        County = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
