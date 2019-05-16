namespace CO599_CP_ABCRenters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        MaritalStatus = c.Int(nullable: false),
                        ContactNumber = c.String(maxLength: 16),
                        EmailAddress = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Addresses", t => t.AddressID, cascadeDelete: true)
                .Index(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AddressID", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "AddressID" });
            DropTable("dbo.Customers");
        }
    }
}
