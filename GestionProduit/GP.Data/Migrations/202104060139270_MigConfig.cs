namespace GP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigConfig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "Mycategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            DropIndex("dbo.Products", new[] { "Categorie_CategoryId" });
            RenameColumn(table: "dbo.Products", name: "Categorie_CategoryId", newName: "categoryId");
            RenameColumn(table: "dbo.Providings", name: "Provider_Id", newName: "Provider");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductId", newName: "Product");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductId", newName: "IX_Product");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_Id", newName: "IX_Provider");
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.Mycategories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Products", "categoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Providers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Providers", "Password", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Providings", new[] { "Product", "Provider" });
            CreateIndex("dbo.Products", "categoryId");
            DropColumn("dbo.Providers", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Providers", "ConfirmPassword", c => c.String());
            DropIndex("dbo.Products", new[] { "categoryId" });
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.Providers", "Password", c => c.String());
            AlterColumn("dbo.Providers", "Email", c => c.String());
            AlterColumn("dbo.Products", "categoryId", c => c.Int());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Mycategories", "Name", c => c.String());
            AddPrimaryKey("dbo.Providings", new[] { "Provider_Id", "Product_ProductId" });
            RenameIndex(table: "dbo.Providings", name: "IX_Provider", newName: "IX_Provider_Id");
            RenameIndex(table: "dbo.Providings", name: "IX_Product", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "Product", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "Provider", newName: "Provider_Id");
            RenameColumn(table: "dbo.Products", name: "categoryId", newName: "Categorie_CategoryId");
            CreateIndex("dbo.Products", "Categorie_CategoryId");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
            RenameTable(name: "dbo.Mycategories", newName: "Categories");
        }
    }
}
