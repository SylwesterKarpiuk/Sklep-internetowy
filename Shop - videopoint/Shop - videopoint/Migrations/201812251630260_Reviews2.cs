namespace Shop___videopoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reviews2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Product_id", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "Product_id" });
            RenameColumn(table: "dbo.Reviews", name: "Product_id", newName: "ProductId");
            AddColumn("dbo.Reviews", "Rating", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "ProductId");
            AddForeignKey("dbo.Reviews", "ProductId", "dbo.Products", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            AlterColumn("dbo.Reviews", "ProductId", c => c.Int());
            DropColumn("dbo.Reviews", "Rating");
            RenameColumn(table: "dbo.Reviews", name: "ProductId", newName: "Product_id");
            CreateIndex("dbo.Reviews", "Product_id");
            AddForeignKey("dbo.Reviews", "Product_id", "dbo.Products", "id");
        }
    }
}
