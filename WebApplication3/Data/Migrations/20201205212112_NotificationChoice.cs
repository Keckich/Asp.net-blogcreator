using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Data.Migrations
{
    public partial class NotificationChoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Notifications",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notifications",
                table: "AspNetUsers");
        }
    }
}
