namespace Shop___videopoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopCreation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_id", "dbo.Categories");
            DropForeignKey("dbo.Reviews", "Product_id", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Category_id" });
            DropIndex("dbo.Reviews", new[] { "Product_id" });
            DropColumn("dbo.Products", "Category_id");
            DropColumn("dbo.Reviews", "Product_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Product_id", c => c.Int());
            AddColumn("dbo.Products", "Category_id", c => c.Int());
            CreateIndex("dbo.Reviews", "Product_id");
            CreateIndex("dbo.Products", "Category_id");
            AddForeignKey("dbo.Reviews", "Product_id", "dbo.Products", "id");
            AddForeignKey("dbo.Products", "Category_id", "dbo.Categories", "id");
        }
    }
}
