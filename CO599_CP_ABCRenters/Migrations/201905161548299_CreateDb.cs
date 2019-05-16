namespace CO599_CP_ABCRenters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 35),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.Int(nullable: false),
                        AvailableDate = c.DateTime(nullable: false),
                        EstateAgent = c.Int(nullable: false),
                        Bedrooms = c.Int(nullable: false),
                        AddressID = c.String(),
                        PetsAllowed = c.Boolean(nullable: false),
                        IsShared = c.Boolean(nullable: false),
                        Address_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.PropertyID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .Index(t => t.Address_AddressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Properties", new[] { "Address_AddressID" });
            DropTable("dbo.Properties");
        }
    }
}
