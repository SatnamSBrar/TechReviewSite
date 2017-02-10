namespace TechReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedStarredToAuthorInReviewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Author", c => c.String());
            DropColumn("dbo.Reviews", "Starred");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Starred", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "Author");
        }
    }
}
