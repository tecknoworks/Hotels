namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcomodationPhoto = c.String(),
                        AcomodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .Index(t => t.AcomodationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "AcomodationId", "dbo.Acomodations");
            DropIndex("dbo.Photos", new[] { "AcomodationId" });
            DropTable("dbo.Photos");
        }
    }
}
