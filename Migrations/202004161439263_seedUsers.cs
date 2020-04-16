namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a1a6423-97ee-4af5-a135-602623bd5da0', N'guest@vidly.com', 0, N'AB+kdrSvyJ5b86Y5TekMdIxqrU+m2rRlyB1t/qOXY3aoPRvlCKx32UOERoJqsXTd4A==', N'c91ef2c7-62fc-40f9-a6a9-0c37644d255d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com');
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd3b4fe82-e474-4236-98d6-b532df8a832e', N'admin@vidly.com', 0, N'AIMP5UkzRgPYx8HO7sHQmk3XfieTP1sTJGkqxe3vtqG3zdNhF9UDY3aVjDRYShAlqg==', N'720913b6-217e-4420-b93f-1ea4b36db05d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com');
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f0055ea6-6f51-4ead-b827-3cfba5a09e88', N'CanManageMovies');
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db9ec3b5-4f0b-4179-9447-7444b99c1551', N'admin1@vidly.com', 0, N'AD4TMTtrA0bqIhUqzW4O3TD+sKIBL0mwrBhCMzyAdxyE9TYHvCz/pnBt2G4gk4pj5g==', N'97aedc15-d10e-447b-bca7-4f9d3f8a108e', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com');
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db9ec3b5-4f0b-4179-9447-7444b99c1551', N'f0055ea6-6f51-4ead-b827-3cfba5a09e88');

");
        }

        public override void Down()
        {
        }
    }
}
