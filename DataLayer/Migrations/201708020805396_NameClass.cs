namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nearbies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfReservation = c.DateTime(nullable: false),
                        DateOfStart = c.DateTime(nullable: false),
                        DateOfEnd = c.DateTime(nullable: false),
                        TotalPayment = c.Single(nullable: false),
                        NumberOfPeople = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.RoomId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        NumberOfAdults = c.Int(nullable: false),
                        NumberOfChildren = c.Int(nullable: false),
                        Photo = c.Binary(),
                        Description = c.String(),
                        NumberOfRoomsAvailable = c.Int(nullable: false),
                        AcomodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .Index(t => t.AcomodationId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        UserId = c.Int(nullable: false),
                        AcomodationId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.AcomodationId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.RoomReservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfStart = c.DateTime(nullable: false),
                        DateOfEnd = c.DateTime(nullable: false),
                        RoomId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.UnityFacilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacilityId = c.Int(nullable: false),
                        AcomodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .ForeignKey("dbo.Facilities", t => t.FacilityId, cascadeDelete: true)
                .Index(t => t.FacilityId)
                .Index(t => t.AcomodationId);
            
            CreateTable(
                "dbo.UnityNearbies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NearbyId = c.Int(nullable: false),
                        Acomodation_Id = c.Int(),
                        AcomodationId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.Acomodation_Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId_Id)
                .ForeignKey("dbo.Nearbies", t => t.NearbyId, cascadeDelete: true)
                .Index(t => t.NearbyId)
                .Index(t => t.Acomodation_Id)
                .Index(t => t.AcomodationId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UnityNearbies", "NearbyId", "dbo.Nearbies");
            DropForeignKey("dbo.UnityNearbies", "AcomodationId_Id", "dbo.Acomodations");
            DropForeignKey("dbo.UnityNearbies", "Acomodation_Id", "dbo.Acomodations");
            DropForeignKey("dbo.UnityFacilities", "FacilityId", "dbo.Facilities");
            DropForeignKey("dbo.UnityFacilities", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.RoomReservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reviews", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.Reservations", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "AcomodationId", "dbo.Acomodations");
            DropIndex("dbo.UnityNearbies", new[] { "AcomodationId_Id" });
            DropIndex("dbo.UnityNearbies", new[] { "Acomodation_Id" });
            DropIndex("dbo.UnityNearbies", new[] { "NearbyId" });
            DropIndex("dbo.UnityFacilities", new[] { "AcomodationId" });
            DropIndex("dbo.UnityFacilities", new[] { "FacilityId" });
            DropIndex("dbo.RoomReservations", new[] { "RoomId" });
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            DropIndex("dbo.Reviews", new[] { "AcomodationId" });
            DropIndex("dbo.Rooms", new[] { "AcomodationId" });
            DropIndex("dbo.Reservations", new[] { "User_Id" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropTable("dbo.UnityNearbies");
            DropTable("dbo.UnityFacilities");
            DropTable("dbo.RoomReservations");
            DropTable("dbo.Reviews");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Nearbies");
        }
    }
}
