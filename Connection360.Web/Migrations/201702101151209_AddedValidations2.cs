namespace Connection360.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedValidations2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brand", "LogoUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Brand", "LogoUrl", c => c.String(nullable: false));
        }
    }
}
