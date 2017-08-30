namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Acomodations", "AcomodationPhoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Acomodations", "AcomodationPhoto", c => c.String());
        }
    }
}
