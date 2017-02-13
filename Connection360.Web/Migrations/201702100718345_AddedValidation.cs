namespace Connection360.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddViewModel", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.AddViewModel", "BrandLogo", c => c.String(nullable: false));
            AlterColumn("dbo.AddViewModel", "BrandDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddViewModel", "BrandDescription", c => c.String());
            AlterColumn("dbo.AddViewModel", "BrandLogo", c => c.String());
            AlterColumn("dbo.AddViewModel", "Name", c => c.String());
        }
    }
}
