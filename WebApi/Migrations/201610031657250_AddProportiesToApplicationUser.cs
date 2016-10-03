namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProportiesToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_Street", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_Suite", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_Zipcode", c => c.String());
            AddColumn("dbo.AspNetUsers", "Website", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Website");
            DropColumn("dbo.AspNetUsers", "Address_Zipcode");
            DropColumn("dbo.AspNetUsers", "Address_City");
            DropColumn("dbo.AspNetUsers", "Address_Suite");
            DropColumn("dbo.AspNetUsers", "Address_Street");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
