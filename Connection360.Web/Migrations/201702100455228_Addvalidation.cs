namespace Connection360.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brand", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Brand", "LogoUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Brand", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Sku", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Sku", "ImageUrl", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sku", "ImageUrl", c => c.String());
            AlterColumn("dbo.Sku", "Name", c => c.String());
            AlterColumn("dbo.Brand", "Description", c => c.String());
            AlterColumn("dbo.Brand", "LogoUrl", c => c.String());
            AlterColumn("dbo.Brand", "Name", c => c.String());
        }
    }
}
