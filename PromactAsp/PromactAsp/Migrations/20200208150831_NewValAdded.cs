using Microsoft.EntityFrameworkCore.Migrations;

namespace PromactAsp.Migrations
{
    public partial class NewValAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isshared",
                table: "Message",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "shareid",
                table: "Message",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isshared",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "shareid",
                table: "Message");
        }
    }
}
