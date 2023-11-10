namespace WebApplicationnew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataBase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
