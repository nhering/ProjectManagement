namespace ProjectManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Card",
                c => new
                    {
                        CardID = c.Int(nullable: false, identity: true),
                        Status = c.Int(),
                        Title = c.String(),
                        Description = c.String(),
                        PersonAssigned_PeopleID = c.Int(),
                    })
                .PrimaryKey(t => t.CardID)
                .ForeignKey("dbo.People", t => t.PersonAssigned_PeopleID)
                .Index(t => t.PersonAssigned_PeopleID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PeopleID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PeopleID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Phase = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Card", "PersonAssigned_PeopleID", "dbo.People");
            DropIndex("dbo.Card", new[] { "PersonAssigned_PeopleID" });
            DropTable("dbo.Project");
            DropTable("dbo.Comment");
            DropTable("dbo.People");
            DropTable("dbo.Card");
        }
    }
}
