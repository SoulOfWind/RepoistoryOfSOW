using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppForTestAspDotNetCoreMVC.Migrations
{
    public partial class ModifyUserAddNickNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "User");
        }
    }
}
