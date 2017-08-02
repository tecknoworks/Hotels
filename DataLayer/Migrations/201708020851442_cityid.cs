namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cityid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Acomodations", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Acomodations", "CityId");
            AddForeignKey("dbo.Acomodations", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Acomodations", "CityId", "dbo.Cities");
            DropIndex("dbo.Acomodations", new[] { "CityId" });
            DropColumn("dbo.Acomodations", "CityId");
        }
    }
}
