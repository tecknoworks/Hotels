namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UnityFacilities", newName: "AcomodationFacilities");
            RenameTable(name: "dbo.UnityNearbies", newName: "AcomodationNearbies");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AcomodationNearbies", newName: "UnityNearbies");
            RenameTable(name: "dbo.AcomodationFacilities", newName: "UnityFacilities");
        }
    }
}
