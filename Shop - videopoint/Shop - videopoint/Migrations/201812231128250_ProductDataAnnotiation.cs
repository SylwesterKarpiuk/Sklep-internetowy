namespace Shop___videopoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDataAnnotiation : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Produkty");
            AlterColumn("dbo.Produkty", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Produkty", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produkty", "Description", c => c.String());
            AlterColumn("dbo.Produkty", "Name", c => c.String());
            RenameTable(name: "dbo.Produkty", newName: "Products");
        }
    }
}
