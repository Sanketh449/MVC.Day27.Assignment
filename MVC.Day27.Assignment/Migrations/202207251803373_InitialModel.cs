namespace MVC.Day27.Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Products",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   SKO_NO = c.Int(nullable: false, identity: true),
                   ProductName = c.String(),
                   Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                   Description = c.String(),
                   IsAvailable = c.Boolean(),
                   CreatedDate = c.DateTime(nullable: false, defaultValueSql: "Getdate()"),

               })
        
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
