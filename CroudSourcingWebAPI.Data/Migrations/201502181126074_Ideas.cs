namespace CrowdSourcingWebAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ideas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationSkins", "Slogan", c => c.String());
            AddColumn("dbo.ApplicationSkins", "LogoUrl", c => c.String());
            AddColumn("dbo.ApplicationSkins", "BaseUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationSkins", "BaseUrl");
            DropColumn("dbo.ApplicationSkins", "LogoUrl");
            DropColumn("dbo.ApplicationSkins", "Slogan");
        }
    }
}
