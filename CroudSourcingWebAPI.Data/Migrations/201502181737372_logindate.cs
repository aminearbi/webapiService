namespace CrowdSourcingWebAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class logindate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logs", "EventDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Logs", "LoginDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Logs", "LoginDate", c => c.DateTime());
            DropColumn("dbo.Logs", "EventDate");
        }
    }
}
