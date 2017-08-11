namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoomPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomPhoto", c => c.String());
            DropColumn("dbo.Rooms", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Photo", c => c.Binary());
            DropColumn("dbo.Rooms", "RoomPhoto");
        }
    }
}
