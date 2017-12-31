namespace BusinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspnetuser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemInStock = c.Int(),
                        ReOrderLevel = c.Int(),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        SupplierID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        TelNumber = c.Int(nullable: false),
                        Email = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "CreatedBy", c => c.String());
            AddColumn("dbo.Customers", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "ModifiedBy", c => c.String());
            AddColumn("dbo.Customers", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "SupplierID", "dbo.Suppliers");
            DropIndex("dbo.Items", new[] { "SupplierID" });
            DropColumn("dbo.Customers", "ModifiedDate");
            DropColumn("dbo.Customers", "ModifiedBy");
            DropColumn("dbo.Customers", "CreatedDate");
            DropColumn("dbo.Customers", "CreatedBy");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Items");
        }
    }
}
