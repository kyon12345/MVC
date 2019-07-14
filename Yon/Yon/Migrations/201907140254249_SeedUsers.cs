namespace Yon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6f69abb0-53d1-4de6-ae8f-3916aaeeefb2', N'admin@yon.com', 0, N'AMfpdhegZcvPmpK1Nkxz8E37OG97FB0ldxWYzhP93nyCY8HRVrj7OpkULUuApqvEcw==', N'59338f9f-d5fd-4376-a6d0-e882205b5791', NULL, 0, 0, NULL, 1, 0, N'admin@yon.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b098435-615a-499e-84d4-b3acc5c2eeda', N'guest@yon.com', 0, N'AJhRRpDBbXUcXV6sXKTo62T731eWr6vt9jM8CXsACyTLKcrnQmdfR/3JyNOksm2aBw==', N'e3b2a702-84d4-46bc-8382-31b89a57e247', NULL, 0, 0, NULL, 1, 0, N'guest@yon.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9d865f10-2675-4408-892d-6b51a6093a90', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6f69abb0-53d1-4de6-ae8f-3916aaeeefb2', N'9d865f10-2675-4408-892d-6b51a6093a90')
");
        }
        
        public override void Down()
        {
        }
    }
}
