namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photosss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Photos", "AccomodationPhoto", c => c.String());
            DropColumn("dbo.Photos", "AcomodationPhoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Photos", "AcomodationPhoto", c => c.String());
            DropColumn("dbo.Photos", "AccomodationPhoto");
        }
    }
}
