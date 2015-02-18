namespace CrowdSourcingWebAPI.WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ideas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationSkins",
                c => new
                    {
                        ApplicationSkinId = c.Int(nullable: false, identity: true),
                        TenantMail = c.String(),
                        ThemeURL = c.String(),
                        Slogan = c.String(),
                        LogoUrl = c.String(),
                        BaseUrl = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationSkinId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        TenantMail = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        DatePosted = c.DateTime(nullable: false),
                        IdeaId = c.Int(nullable: false),
                        WriterMail = c.String(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Ideas", t => t.IdeaId, cascadeDelete: true)
                .Index(t => t.IdeaId);
            
            CreateTable(
                "dbo.Ideas",
                c => new
                    {
                        IdeaId = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false),
                        DatePosted = c.DateTime(nullable: false),
                        Score = c.Int(nullable: false),
                        State = c.String(),
                        Text = c.String(nullable: false),
                        prize = c.String(),
                        CategoryId = c.Int(nullable: false),
                        WriterMail = c.String(),
                        TenanMail = c.String(),
                    })
                .PrimaryKey(t => t.IdeaId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        LikeId = c.Int(nullable: false, identity: true),
                        IdeaId = c.Int(nullable: false),
                        WriterMail = c.String(),
                    })
                .PrimaryKey(t => t.LikeId)
                .ForeignKey("dbo.Ideas", t => t.IdeaId, cascadeDelete: true)
                .Index(t => t.IdeaId);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        LoginDate = c.DateTime(),
                        Event = c.String(nullable: false),
                        EventType = c.String(),
                        TenantMail = c.String(),
                    })
                .PrimaryKey(t => t.LogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Likes", "IdeaId", "dbo.Ideas");
            DropForeignKey("dbo.Comments", "IdeaId", "dbo.Ideas");
            DropForeignKey("dbo.Ideas", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Likes", new[] { "IdeaId" });
            DropIndex("dbo.Ideas", new[] { "CategoryId" });
            DropIndex("dbo.Comments", new[] { "IdeaId" });
            DropTable("dbo.Logs");
            DropTable("dbo.Likes");
            DropTable("dbo.Ideas");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
            DropTable("dbo.ApplicationSkins");
        }
    }
}
