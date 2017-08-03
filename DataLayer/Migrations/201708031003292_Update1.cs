namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AcomodationFacilities", newName: "UnityFacilities");
            RenameTable(name: "dbo.AcomodationNearbies", newName: "UnityNearbies");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UnityNearbies", newName: "AcomodationNearbies");
            RenameTable(name: "dbo.UnityFacilities", newName: "AcomodationFacilities");
        }
    }
}
