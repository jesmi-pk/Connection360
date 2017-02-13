namespace Connection360.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeValidation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddViewModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BrandLogo = c.String(),
                        BrandDescription = c.String(),
                        SkuName = c.String(),
                        SkuUrl = c.String(),
                        brand_BrandId = c.Int(),
                        sku_SkuId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brand", t => t.brand_BrandId)
                .ForeignKey("dbo.Sku", t => t.sku_SkuId)
                .Index(t => t.brand_BrandId)
                .Index(t => t.sku_SkuId);
            
            AddColumn("dbo.Sku", "AddViewModel_Id", c => c.Int());
            CreateIndex("dbo.Sku", "AddViewModel_Id");
            AddForeignKey("dbo.Sku", "AddViewModel_Id", "dbo.AddViewModel", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sku", "AddViewModel_Id", "dbo.AddViewModel");
            DropForeignKey("dbo.AddViewModel", "sku_SkuId", "dbo.Sku");
            DropForeignKey("dbo.AddViewModel", "brand_BrandId", "dbo.Brand");
            DropIndex("dbo.Sku", new[] { "AddViewModel_Id" });
            DropIndex("dbo.AddViewModel", new[] { "sku_SkuId" });
            DropIndex("dbo.AddViewModel", new[] { "brand_BrandId" });
            DropColumn("dbo.Sku", "AddViewModel_Id");
            DropTable("dbo.AddViewModel");
        }
    }
}
