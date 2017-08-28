namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Reservations", name: "UserId", newName: "User_Id1");
            RenameColumn(table: "dbo.Reviews", name: "UserId", newName: "User_Id1");
            RenameIndex(table: "dbo.Reservations", name: "IX_UserId", newName: "IX_User_Id1");
            RenameIndex(table: "dbo.Reviews", name: "IX_UserId", newName: "IX_User_Id1");
            AddColumn("dbo.Reservations", "User_Id", c => c.String());
            AddColumn("dbo.Reviews", "User_Id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "User_Id");
            DropColumn("dbo.Reservations", "User_Id");
            RenameIndex(table: "dbo.Reviews", name: "IX_User_Id1", newName: "IX_UserId");
            RenameIndex(table: "dbo.Reservations", name: "IX_User_Id1", newName: "IX_UserId");
            RenameColumn(table: "dbo.Reviews", name: "User_Id1", newName: "UserId");
            RenameColumn(table: "dbo.Reservations", name: "User_Id1", newName: "UserId");
        }
    }
}
