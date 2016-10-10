using System.Data.Entity.Migrations;

namespace WebApi.Persistence.Migrations
{
    public partial class SeedAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address_Street], [Address_Suite], [Address_City], [Address_Zipcode], [Website]) VALUES (N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'allan@pinkerton.com', 0, N'AD1rTkxKzzhcdZVQbhBtO7kh7DwmrlwW3IKxNQ5niyrF9Z0UJUwm4omyFJbbel5JAw==', N'ce2cc2cd-6d1c-48e3-b5a8-8c6d6b31c039', N'435-787-1222', 0, 0, NULL, 1, 0, N'allan@pinkerton.com', N'Allan Pinkerton', N'123rd St SE', N'9876', N'Chicago', N'60004', N'pinkerton.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7bd27826-054a-426e-b879-5629f0102847', N'CanAccessApi')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'7bd27826-054a-426e-b879-5629f0102847')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
