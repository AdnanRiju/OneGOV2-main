namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewSeed : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "ProductId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Products", "Title", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Title", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Products", "ProductId");
            AddPrimaryKey("dbo.Products", "Title");
        }
    }
}
