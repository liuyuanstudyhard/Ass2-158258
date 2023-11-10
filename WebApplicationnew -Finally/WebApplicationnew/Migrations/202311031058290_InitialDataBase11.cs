namespace WebApplicationnew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataBase11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
