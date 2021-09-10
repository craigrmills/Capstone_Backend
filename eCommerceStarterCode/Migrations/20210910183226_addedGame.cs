using Microsoft.EntityFrameworkCore.Migrations;

namespace BattleSmithAPI.Migrations
{
    public partial class addedGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "311e3c13-8d80-4230-b899-a390a3158ea5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb77800e-070a-4dfb-a47e-ea751d93534e");

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Player2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P1Faction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P2Faction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P1Score = table.Column<int>(type: "int", nullable: false),
                    P2Score = table.Column<int>(type: "int", nullable: false),
                    Loser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad5cc8d0-1fcc-40b4-95a8-2aece7d2044f", "6b557264-c6d1-442c-9dc5-96df2a06293a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49f709fc-aac3-4e7b-bc43-9809bfe53cb0", "8520340c-4bb3-4d8d-bc28-040b6518467e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f709fc-aac3-4e7b-bc43-9809bfe53cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad5cc8d0-1fcc-40b4-95a8-2aece7d2044f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb77800e-070a-4dfb-a47e-ea751d93534e", "23cf1934-d91b-46ef-b1b7-c4d6fa255788", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "311e3c13-8d80-4230-b899-a390a3158ea5", "d9281cce-18b4-4029-a4d3-0c91bca60353", "Admin", "ADMIN" });
        }
    }
}
