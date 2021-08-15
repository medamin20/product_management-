namespace GP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigAdres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "adresse_StreetAdess", c => c.String());
            AddColumn("dbo.Products", "adresse_City", c => c.String());
            DropColumn("dbo.Products", "City");
            DropColumn("dbo.Products", "StreetAdress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "StreetAdress", c => c.String());
            AddColumn("dbo.Products", "City", c => c.String());
            DropColumn("dbo.Products", "adresse_City");
            DropColumn("dbo.Products", "adresse_StreetAdess");
        }
    }
}
