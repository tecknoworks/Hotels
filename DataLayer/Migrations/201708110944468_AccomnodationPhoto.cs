namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccomnodationPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Acomodations", "AcomodationPhoto", c => c.String());
            DropColumn("dbo.Acomodations", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Acomodations", "Picture", c => c.Binary());
            DropColumn("dbo.Acomodations", "AcomodationPhoto");
        }
    }
}
