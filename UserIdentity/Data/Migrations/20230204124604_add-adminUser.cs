using Microsoft.EntityFrameworkCore.Migrations;

namespace UserIdentity.Data.Migrations
{
    public partial class addadminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [FirstName], [LastName], [ProfilePicture], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'6e8b9747-b777-4317-a9a9-9f2a104d7b1b', N'aadmin', N'testtt', NULL, 0, N'6f834b52-1666-4720-9e6b-f628eeabfdcf', N'admin@test.test', 0, 1, NULL, N'ADMIN@TEST.TEST', N'ADMIN', N'AQAAAAEAACcQAAAAEENc2qmDSPZxFhtI+z9ZOFRcQeixLFfBuYEhAw/+UnqRNF1ifXxUKg+ui8wXydBNQw==', NULL, 0, N'XKXJVZ2H2S72VJOYCJFMLCD6P7OTVMVQ', 0, N'admin')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '6e8b9747-b777-4317-a9a9-9f2a104d7b1b'");
        }
    }
}
