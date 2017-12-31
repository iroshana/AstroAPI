namespace BusinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Outlet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Outlets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        TelNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "OutletID", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "NIC", c => c.String(nullable: false));
            CreateIndex("dbo.Customers", "OutletID");
            AddForeignKey("dbo.Customers", "OutletID", "dbo.Outlets", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "OutletID", "dbo.Outlets");
            DropIndex("dbo.Customers", new[] { "OutletID" });
            AlterColumn("dbo.Customers", "NIC", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "OutletID");
            DropTable("dbo.Outlets");
        }
    }
}
