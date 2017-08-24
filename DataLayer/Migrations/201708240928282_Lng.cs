namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lng : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Lng", c => c.String());
            AddColumn("dbo.Countries", "Lat", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "Lat");
            DropColumn("dbo.Countries", "Lng");
        }
    }
}
