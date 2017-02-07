namespace Connection360.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LogoUrl = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.BrandSkuMap",
                c => new
                    {
                        BrandSkuMapId = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        SkuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BrandSkuMapId)
                .ForeignKey("dbo.Brand", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Sku", t => t.SkuId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.SkuId);
            
            CreateTable(
                "dbo.Sku",
                c => new
                    {
                        SkuId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SkuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BrandSkuMap", "SkuId", "dbo.Sku");
            DropForeignKey("dbo.BrandSkuMap", "BrandId", "dbo.Brand");
            DropIndex("dbo.BrandSkuMap", new[] { "SkuId" });
            DropIndex("dbo.BrandSkuMap", new[] { "BrandId" });
            DropTable("dbo.Sku");
            DropTable("dbo.BrandSkuMap");
            DropTable("dbo.Brand");
        }
    }
}
