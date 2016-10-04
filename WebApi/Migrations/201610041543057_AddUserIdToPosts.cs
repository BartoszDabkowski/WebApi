namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIdToPosts : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Posts", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.Posts", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
            AddColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "UserId");
            RenameIndex(table: "dbo.Posts", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Posts", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
