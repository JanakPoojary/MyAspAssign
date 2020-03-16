using Microsoft.EntityFrameworkCore.Migrations;

namespace PromactAsp.Migrations
{
    public partial class Seeddataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "messageid", "iscomment", "message", "msglikes", "parentid", "username" },
                values: new object[] { 1, 0, "I am Ironman", 3000, 0, "Ironman" });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "messageid", "iscomment", "message", "msglikes", "parentid", "username" },
                values: new object[] { 2, 0, "Bring me Thanos", 4000, 0, "Thor" });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "messageid", "iscomment", "message", "msglikes", "parentid", "username" },
                values: new object[] { 3, 0, "Avengers Assemble", 2000, 0, "Captain America" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "messageid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "messageid",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "messageid",
                keyValue: 3);
        }
    }
}
