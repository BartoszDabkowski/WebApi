namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropUser_IdFromPostTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "UserId");
            RenameColumn(table: "dbo.Posts", name: "User_Id", newName: "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Posts", name: "UserId", newName: "User_Id");
        }
    }
}
