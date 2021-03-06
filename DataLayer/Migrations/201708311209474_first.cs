namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.AcomodationFacilities",
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
                "dbo.Acomodations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Address = c.String(),
                        Name = c.String(),
                        NumberOfStars = c.Int(nullable: false),
                        Description = c.String(),
                        PhoneNumber = c.String(),
                        WebSite = c.String(),
                        Lat = c.String(),
                        Lng = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                        Lat = c.String(),
                        Lng = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lng = c.String(),
                        Lat = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AcomodationNearbies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NearbyId = c.Int(nullable: false),
                        AcomodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .ForeignKey("dbo.Nearbies", t => t.NearbyId, cascadeDelete: true)
                .Index(t => t.NearbyId)
                .Index(t => t.AcomodationId);
            
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
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccomodationPhoto = c.String(),
                        AcomodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .Index(t => t.AcomodationId);
            
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
                        RoomReservationId = c.Int(nullable: false),
                        User_Id = c.String(),
                        User_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomReservations", t => t.RoomReservationId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id1)
                .Index(t => t.RoomReservationId)
                .Index(t => t.User_Id1);
            
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
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        NumberOfAdults = c.Int(nullable: false),
                        NumberOfChildren = c.Int(nullable: false),
                        RoomPhoto = c.String(),
                        Description = c.String(),
                        NumberOfRoomsAvailable = c.Int(nullable: false),
                        AcomodationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .Index(t => t.AcomodationId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        User_Id = c.String(),
                        AcomodationId = c.Int(nullable: false),
                        User_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acomodations", t => t.AcomodationId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id1)
                .Index(t => t.AcomodationId)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Reviews", "User_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reviews", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.Reservations", "User_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reservations", "RoomReservationId", "dbo.RoomReservations");
            DropForeignKey("dbo.RoomReservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.Photos", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.AcomodationNearbies", "NearbyId", "dbo.Nearbies");
            DropForeignKey("dbo.AcomodationNearbies", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.AcomodationFacilities", "FacilityId", "dbo.Facilities");
            DropForeignKey("dbo.AcomodationFacilities", "AcomodationId", "dbo.Acomodations");
            DropForeignKey("dbo.Acomodations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Reviews", new[] { "User_Id1" });
            DropIndex("dbo.Reviews", new[] { "AcomodationId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Rooms", new[] { "AcomodationId" });
            DropIndex("dbo.RoomReservations", new[] { "RoomId" });
            DropIndex("dbo.Reservations", new[] { "User_Id1" });
            DropIndex("dbo.Reservations", new[] { "RoomReservationId" });
            DropIndex("dbo.Photos", new[] { "AcomodationId" });
            DropIndex("dbo.AcomodationNearbies", new[] { "AcomodationId" });
            DropIndex("dbo.AcomodationNearbies", new[] { "NearbyId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Acomodations", new[] { "CityId" });
            DropIndex("dbo.AcomodationFacilities", new[] { "AcomodationId" });
            DropIndex("dbo.AcomodationFacilities", new[] { "FacilityId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Reviews");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomReservations");
            DropTable("dbo.Reservations");
            DropTable("dbo.Photos");
            DropTable("dbo.Nearbies");
            DropTable("dbo.AcomodationNearbies");
            DropTable("dbo.Facilities");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Acomodations");
            DropTable("dbo.AcomodationFacilities");
        }
    }
}
