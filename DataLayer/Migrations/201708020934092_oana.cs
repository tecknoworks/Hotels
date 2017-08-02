namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oana : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Acomodations", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Acomodations", "Name", c => c.String());
        }
    }
}
