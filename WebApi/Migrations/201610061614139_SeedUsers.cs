namespace WebApi.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address_Street], [Address_Suite], [Address_City], [Address_Zipcode], [Website]) VALUES (N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'kate@pinkerton.com', 0, N'AD1rTkxKzzhcdZVQbhBtO7kh7DwmrlwW3IKxNQ5niyrF9Z0UJUwm4omyFJbbel5JAw==', N'ce2cc2cd-6d1c-48e3-b5a8-8c6d6b31c039', N'334-125-8787', 0, 0, NULL, 1, 0, N'kate@pinkerton.com', N'Kate Warne', N'45th St NW', N'9877', N'Seattle', N'98988', N'pinkerton.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address_Street], [Address_Suite], [Address_City], [Address_Zipcode], [Website]) VALUES (N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'john@pinkerton.com', 0, N'AD1rTkxKzzhcdZVQbhBtO7kh7DwmrlwW3IKxNQ5niyrF9Z0UJUwm4omyFJbbel5JAw==', N'ce2cc2cd-6d1c-48e3-b5a8-8c6d6b31c039', N'425-178-1850', 0, 0, NULL, 1, 0, N'john@pinkerton.com', N'John Scobell', N'16th Ave NE', N'9888', N'New York City', N'12344', N'pinkerton.com')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
