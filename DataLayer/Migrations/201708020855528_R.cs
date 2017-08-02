namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class R : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Reservations", name: "RoomId", newName: "RoomReservationId");
            RenameIndex(table: "dbo.Reservations", name: "IX_RoomId", newName: "IX_RoomReservationId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Reservations", name: "IX_RoomReservationId", newName: "IX_RoomId");
            RenameColumn(table: "dbo.Reservations", name: "RoomReservationId", newName: "RoomId");
        }
    }
}
