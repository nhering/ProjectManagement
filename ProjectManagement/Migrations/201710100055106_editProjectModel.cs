namespace ProjectManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editProjectModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "ProjectID", c => c.Int(nullable: false));
            AddColumn("dbo.Comment", "CardID", c => c.Int(nullable: false));
            AddColumn("dbo.Comment", "PeopleID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comment", "PeopleID");
            DropColumn("dbo.Comment", "CardID");
            DropColumn("dbo.Card", "ProjectID");
        }
    }
}
