namespace NorthwindWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestModification : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Persons", newName: "Person");
            RenameTable(name: "dbo.ShopCarts", newName: "ShopCart");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ShopCart", newName: "ShopCarts");
            RenameTable(name: "dbo.Person", newName: "Persons");
        }
    }
}
