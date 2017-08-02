namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class er : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Acomodations", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Acomodations", "Name");
        }
    }
}
