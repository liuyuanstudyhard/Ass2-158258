namespace WebApplicationnew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "D", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "D");
        }
    }
}
