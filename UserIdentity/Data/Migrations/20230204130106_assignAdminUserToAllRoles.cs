using Microsoft.EntityFrameworkCore.Migrations;

namespace UserIdentity.Data.Migrations
{
    public partial class assignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].UsersRoles (UserId, RoleId) SELECT '6e8b9747-b777-4317-a9a9-9f2a104d7b1b', Id FROM [security].Roles ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].UsersRoles WHERE UserId = '6e8b9747-b777-4317-a9a9-9f2a104d7b1b'");
        }
    }
}
