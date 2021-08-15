namespace GP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migconfg : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "DateProd", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Providers", "DateCreated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Providers", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateProd", c => c.DateTime(nullable: false));
        }
    }
}
