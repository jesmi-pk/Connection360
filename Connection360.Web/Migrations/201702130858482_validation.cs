namespace Connection360.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sku", "AddViewModel_Id", "dbo.AddViewModel");
            DropIndex("dbo.Sku", new[] { "AddViewModel_Id" });
            DropColumn("dbo.AddViewModel", "Name");
            DropColumn("dbo.AddViewModel", "BrandLogo");
            DropColumn("dbo.AddViewModel", "BrandDescription");
            DropColumn("dbo.AddViewModel", "SkuName");
            DropColumn("dbo.AddViewModel", "SkuUrl");
            DropColumn("dbo.Sku", "AddViewModel_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sku", "AddViewModel_Id", c => c.Int());
            AddColumn("dbo.AddViewModel", "SkuUrl", c => c.String());
            AddColumn("dbo.AddViewModel", "SkuName", c => c.String());
            AddColumn("dbo.AddViewModel", "BrandDescription", c => c.String(nullable: false));
            AddColumn("dbo.AddViewModel", "BrandLogo", c => c.String(nullable: false));
            AddColumn("dbo.AddViewModel", "Name", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Sku", "AddViewModel_Id");
            AddForeignKey("dbo.Sku", "AddViewModel_Id", "dbo.AddViewModel", "Id");
        }
    }
}
