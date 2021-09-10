using Microsoft.EntityFrameworkCore.Migrations;

namespace BattleSmithAPI.Migrations
{
    public partial class allModelsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f709fc-aac3-4e7b-bc43-9809bfe53cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad5cc8d0-1fcc-40b4-95a8-2aece7d2044f");

            migrationBuilder.AddColumn<int>(
                name: "Faction1FactionId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Faction2FactionId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FactionLFactionId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FactionWFactionId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User1Id",
                table: "Games",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User2Id",
                table: "Games",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeStore",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    FactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GamesPlayed = table.Column<int>(type: "int", nullable: false),
                    WinRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.FactionId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.ProductOrderId);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecc51937-1319-4984-8fa6-98ed9cb41128", "997f3568-fb5d-487d-8dce-dad5e5122874", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e514520c-b4ec-408f-84fd-b71b8ae428ee", "595ca553-b481-4a14-8242-b516ceec4084", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_Faction1FactionId",
                table: "Games",
                column: "Faction1FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Faction2FactionId",
                table: "Games",
                column: "Faction2FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_FactionLFactionId",
                table: "Games",
                column: "FactionLFactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_FactionWFactionId",
                table: "Games",
                column: "FactionWFactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_User1Id",
                table: "Games",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_User2Id",
                table: "Games",
                column: "User2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HomeStore",
                table: "AspNetUsers",
                column: "HomeStore");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_ProductId",
                table: "ProductOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Stores_HomeStore",
                table: "AspNetUsers",
                column: "HomeStore",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_User1Id",
                table: "Games",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_User2Id",
                table: "Games",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Factions_Faction1FactionId",
                table: "Games",
                column: "Faction1FactionId",
                principalTable: "Factions",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Factions_Faction2FactionId",
                table: "Games",
                column: "Faction2FactionId",
                principalTable: "Factions",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Factions_FactionLFactionId",
                table: "Games",
                column: "FactionLFactionId",
                principalTable: "Factions",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Factions_FactionWFactionId",
                table: "Games",
                column: "FactionWFactionId",
                principalTable: "Factions",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Stores_HomeStore",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_User1Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_User2Id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Factions_Faction1FactionId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Factions_Faction2FactionId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Factions_FactionLFactionId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Factions_FactionWFactionId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Games_Faction1FactionId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Faction2FactionId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_FactionLFactionId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_FactionWFactionId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_User1Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_User2Id",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HomeStore",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e514520c-b4ec-408f-84fd-b71b8ae428ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecc51937-1319-4984-8fa6-98ed9cb41128");

            migrationBuilder.DropColumn(
                name: "Faction1FactionId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Faction2FactionId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FactionLFactionId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FactionWFactionId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "User1Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "User2Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "HomeStore",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad5cc8d0-1fcc-40b4-95a8-2aece7d2044f", "6b557264-c6d1-442c-9dc5-96df2a06293a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49f709fc-aac3-4e7b-bc43-9809bfe53cb0", "8520340c-4bb3-4d8d-bc28-040b6518467e", "Admin", "ADMIN" });
        }
    }
}
