namespace Eclerx.Program3.RupaliDound.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ContactName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Pincode = c.Int(nullable: false),
                        MobileNo = c.Int(nullable: false),
                        EmailId = c.String(),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "Getdate()"),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.SupplierId)
                .Index(t => t.MobileNo, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Suppliers", new[] { "MobileNo" });
            DropTable("dbo.Suppliers");
        }
    }
}
