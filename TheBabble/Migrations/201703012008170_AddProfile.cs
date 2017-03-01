namespace TheBabble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUserApplicationUsers",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id1 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.ApplicationUser_Id1 })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id1)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id1);
            
            AddColumn("dbo.Profiles", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Profiles", "ApplicationUser_Id");
            AddForeignKey("dbo.Profiles", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Profiles", "Email");
            DropTable("dbo.Posts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        CommentForm = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
            AddColumn("dbo.Profiles", "Email", c => c.String());
            DropForeignKey("dbo.Profiles", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUserApplicationUsers", "ApplicationUser_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUserApplicationUsers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserApplicationUsers", new[] { "ApplicationUser_Id1" });
            DropIndex("dbo.ApplicationUserApplicationUsers", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Profiles", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Profiles", "ApplicationUser_Id");
            DropTable("dbo.ApplicationUserApplicationUsers");
        }
    }
}
