using System.Data.Entity.Migrations;

namespace WebApi.Persistence.Migrations
{
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[AspNetUsers] ON
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address_Street], [Address_Suite], [Address_City], [Address_Zipcode], [Website]) VALUES (N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'kate@pinkerton.com', 0, N'AD1rTkxKzzhcdZVQbhBtO7kh7DwmrlwW3IKxNQ5niyrF9Z0UJUwm4omyFJbbel5JAw==', N'ce2cc2cd-6d1c-48e3-b5a8-8c6d6b31c039', N'334-125-8787', 0, 0, NULL, 1, 0, N'kate@pinkerton.com', N'Kate Warne', N'45th St NW', N'9877', N'Seattle', N'98988', N'pinkerton.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address_Street], [Address_Suite], [Address_City], [Address_Zipcode], [Website]) VALUES (N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'john@pinkerton.com', 0, N'AD1rTkxKzzhcdZVQbhBtO7kh7DwmrlwW3IKxNQ5niyrF9Z0UJUwm4omyFJbbel5JAw==', N'ce2cc2cd-6d1c-48e3-b5a8-8c6d6b31c039', N'425-178-1850', 0, 0, NULL, 1, 0, N'john@pinkerton.com', N'John Scobell', N'16th Ave NE', N'9888', N'New York City', N'12344', N'pinkerton.com')
                SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF

                SET IDENTITY_INSERT [dbo].[Posts] ON
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (2, N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'Employment Screening', N'Pinkerton is a worldwide industry leader in development and delivery of compliance-focused, employee screening solutions specifically designed to cut costs and save time.', N'2016-10-04 00:00:00')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (3, N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'Security Risk Management', N'Pinkerton offers the global resources and expertise to provide comprehensive Security Risk Management and Consulting Support for any or all of your locations around the world.', N'2015-10-05 00:00:00')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (4, N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'Investigations', N'The Pinkerton name has been synonymous with trusted, reliable investigation services for nearly 170 years. Today, we provide international expertise in all forms of investigations that take place inside and outside your company.', N'2016-10-05 00:00:00')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (5, N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'Protective Security', N'Pinkerton combines expertise and industry-leading intelligence to deliver reliable VIP protection anywhere around the globe at a moment’s notice.', N'2016-10-05 00:00:00')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (6, N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'Response Services', N'Do you need boots on the ground overnight and overseas due to a disaster? Pinkerton’s global network of resources responds to and helps manage crisis situations whenever and wherever they occur.', N'2016-10-05 00:00:00')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (7, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Intelligence Services', N'Every service Pinkerton provides is augmented by incorporating information and analysis that is timely, reliable and relevant.', N'2016-10-06 00:00:00')
                INSERT INTO [dbo].[Posts] ([Id], [UserId], [Title], [Body], [DateTime]) VALUES (9, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Service Models', N'Pinkerton customizes its service model based on the unique needs of each client to provide the most effective and efficient risk management solution possible.', N'2016-10-07 00:00:00')
                SET IDENTITY_INSERT [dbo].[Posts] OFF

                SET IDENTITY_INSERT [dbo].[Comments] ON
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (1, 2, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Thousands of companies throughout the world rely on Pinkerton Employment Screening to provide comprehensive Human Resource Employment Background Screening Services and Solutions.', N'2016-10-04 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (2, 2, N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'Our solutions incorporate standardized best practices which help streamline your workflow and maximize productivity throughout the entire employee life cycle.', N'2016-10-04 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (4, 3, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Whether your organization functions in a single, multi-story environment or operates facilities in locations scattered around the world, Pinkerton can develop comprehensive safety and security plans filled with effective strategies and programs designed to protect every important element of your business: employees, customers, supply chain, the physical environment, and your products.', N'2016-10-04 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (5, 5, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'For nearly 170 years, Pinkerton’s highly-skilled agents have provided protection for Fortune 100 CEOs and their workforces, famous entertainers, athletes, high-net worth individuals, royal families and diplomats.', N'2016-10-05 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (6, 5, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Whether you need immediate protection or are planning for a future event, Pinkerton will provide a thorough assessment of your situation and customize a service that best fits your needs.', N'2016-10-06 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (7, 5, N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'We tailor our services to fit the unique needs of each client. Along with our flexibility and adaptability, Pinkerton pays attention to key details. When location or timing requires a change of agents, we can seamlessly transfer services without impacting our clients.', N'2016-10-04 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (8, 4, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Some investigations may simply involve monitoring a single employee; other investigations may be complex, uncovering elaborate schemes at multiple facilities in numerous countries. ', N'2016-10-03 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (11, 4, N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'Pinkerton is an industry leader in providing end-to-end investigation solutions while maintaining confidentiality.', N'2016-10-07 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (12, 4, N'47b28585-f6b5-492d-afe0-873c4e64e5be', N'Pinkerton agents are supported by cutting-edge intelligence and information technology to assist at every step of the investigation.', N'2016-10-07 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (14, 7, N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'Our Intelligence Services are overseen by Pinkerton’s Global Risk Group, comprised of highly-experienced and trained individuals with backgrounds in civilian and military intelligence, as well as traditional security fields. ', N'2016-10-07 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (15, 9, N'47b28585-f6b5-492d-afe0-873c4e64e5bc', N'Our clients have discovered one of the most efficient risk management staffing solutions, the Pinkerton Dedicated Professional – highly-experienced professionals that are embedded in an organization to deliver superior, reliable and timely risk mitigation.', N'2016-10-07 00:00:00')
                INSERT INTO [dbo].[Comments] ([Id], [PostId], [UserId], [Body], [DateTime]) VALUES (17, 9, N'47b28585-f6b5-492d-afe0-873c4e64e5bd', N'Bottom line: because Pinkerton is focused on your security, you can focus on your business.', N'2016-10-08 00:00:00')
                SET IDENTITY_INSERT [dbo].[Comments] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
