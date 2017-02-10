namespace TechReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationSetDateToAutomaticallyBeAssignedUponPublication : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Date", c => c.DateTime(nullable: false));
        }
    }
}
