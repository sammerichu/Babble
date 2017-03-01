namespace TheBabble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Name", c => c.String());
            AddColumn("dbo.Profiles", "Email", c => c.String());
            AddColumn("dbo.Profiles", "About", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "About");
            DropColumn("dbo.Profiles", "Email");
            DropColumn("dbo.Profiles", "Name");
        }
    }
}
