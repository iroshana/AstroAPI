namespace BusinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        NIC = c.String(),
                        MobileNumber = c.Int(nullable: false),
                        HomeNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
