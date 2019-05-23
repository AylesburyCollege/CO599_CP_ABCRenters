namespace CO599_CP_ABCRenters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifypropertyimage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyImages",
                c => new
                    {
                        PropertyImageID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 255),
                        Caption = c.String(nullable: false, maxLength: 50),
                        ImageFormat = c.Int(nullable: false),
                        Rooms = c.Int(nullable: false),
                        PropertyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyImageID)
                .ForeignKey("dbo.Properties", t => t.PropertyID, cascadeDelete: true)
                .Index(t => t.PropertyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyImages", "PropertyID", "dbo.Properties");
            DropIndex("dbo.PropertyImages", new[] { "PropertyID" });
            DropTable("dbo.PropertyImages");
        }
    }
}
