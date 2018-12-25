namespace Shop___videopoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Product_id", c => c.Int());
            CreateIndex("dbo.Reviews", "Product_id");
            AddForeignKey("dbo.Reviews", "Product_id", "dbo.Products", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Product_id", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "Product_id" });
            DropColumn("dbo.Reviews", "Product_id");
        }
    }
}
