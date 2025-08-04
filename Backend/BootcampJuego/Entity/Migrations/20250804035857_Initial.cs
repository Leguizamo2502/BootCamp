using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Resistance = table.Column<int>(type: "int", nullable: false),
                    Magic = table.Column<int>(type: "int", nullable: false),
                    Force = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberRound = table.Column<int>(type: "int", nullable: false),
                    SelectedAttribute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rounds_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    CurrentScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GamePlayerId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Used = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deck_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deck_GamePlayers_GamePlayerId",
                        column: x => x.GamePlayerId,
                        principalTable: "GamePlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsedValue = table.Column<int>(type: "int", nullable: false),
                    Winner = table.Column<bool>(type: "bit", nullable: false),
                    RoundId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    GamePlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moves_GamePlayers_GamePlayerId",
                        column: x => x.GamePlayerId,
                        principalTable: "GamePlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moves_Rounds_RoundId",
                        column: x => x.RoundId,
                        principalTable: "Rounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Defense", "Force", "Health", "ImageUrl", "Magic", "Resistance", "Speed" },
                values: new object[,]
                {
                    { 1, 134, 155, 186, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/1.png", 163, 113, 64 },
                    { 2, 90, 95, 52, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/2.png", 69, 176, 168 },
                    { 3, 160, 98, 95, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/3.png", 199, 63, 133 },
                    { 4, 132, 123, 133, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/4.png", 65, 115, 58 },
                    { 5, 63, 153, 71, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/5.png", 59, 112, 183 },
                    { 6, 69, 193, 76, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/6.png", 140, 117, 154 },
                    { 7, 120, 76, 179, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/7.png", 166, 70, 88 },
                    { 8, 121, 73, 100, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/8.png", 68, 58, 184 },
                    { 9, 140, 184, 196, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/9.png", 64, 93, 96 },
                    { 10, 99, 177, 149, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/10.png", 146, 72, 106 },
                    { 11, 64, 70, 54, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/11.png", 52, 126, 76 },
                    { 12, 111, 107, 86, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/12.png", 197, 77, 146 },
                    { 13, 122, 136, 59, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/13.png", 61, 183, 60 },
                    { 14, 81, 180, 124, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/14.png", 75, 162, 109 },
                    { 15, 57, 147, 190, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/15.png", 126, 81, 130 },
                    { 16, 73, 100, 64, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/16.png", 90, 121, 67 },
                    { 17, 194, 62, 84, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/17.png", 79, 124, 87 },
                    { 18, 169, 174, 70, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/18.png", 116, 172, 69 },
                    { 19, 95, 163, 80, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/19.png", 179, 178, 178 },
                    { 20, 162, 93, 108, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/20.png", 128, 90, 108 },
                    { 21, 125, 57, 199, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/21.png", 148, 177, 102 },
                    { 22, 175, 165, 66, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/22.png", 156, 97, 124 },
                    { 23, 97, 168, 98, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/23.png", 122, 170, 169 },
                    { 24, 187, 117, 182, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/24.png", 129, 54, 171 },
                    { 25, 191, 199, 61, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/25.png", 67, 111, 135 },
                    { 26, 65, 169, 159, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/26.png", 87, 52, 195 },
                    { 27, 158, 134, 173, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/27.png", 111, 158, 134 },
                    { 28, 156, 84, 188, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/28.png", 125, 146, 51 },
                    { 29, 76, 185, 53, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/29.png", 164, 56, 187 },
                    { 30, 186, 87, 83, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/30.png", 55, 174, 114 },
                    { 31, 148, 80, 129, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/31.png", 188, 182, 175 },
                    { 32, 107, 182, 104, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/32.png", 105, 53, 198 },
                    { 33, 166, 157, 74, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/33.png", 84, 175, 80 },
                    { 34, 174, 161, 143, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/34.png", 96, 118, 200 },
                    { 35, 67, 192, 165, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/35.png", 57, 148, 71 },
                    { 36, 188, 124, 150, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/36.png", 173, 133, 107 },
                    { 37, 172, 140, 177, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/37.png", 143, 130, 197 },
                    { 38, 193, 127, 198, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/38.png", 196, 159, 173 },
                    { 39, 79, 59, 69, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/39.png", 103, 163, 180 },
                    { 40, 131, 104, 174, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/40.png", 110, 150, 132 },
                    { 41, 102, 108, 127, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/41.png", 62, 149, 125 },
                    { 42, 51, 128, 72, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/42.png", 108, 59, 159 },
                    { 43, 112, 111, 114, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/43.png", 93, 194, 66 },
                    { 44, 71, 94, 131, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/44.png", 177, 152, 112 },
                    { 45, 127, 53, 88, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/45.png", 50, 138, 95 },
                    { 46, 137, 170, 154, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/46.png", 184, 125, 86 },
                    { 47, 52, 164, 168, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/47.png", 70, 114, 103 },
                    { 48, 159, 109, 62, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/48.png", 114, 191, 79 },
                    { 49, 105, 71, 178, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/49.png", 77, 195, 61 },
                    { 50, 55, 130, 170, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/50.png", 134, 168, 72 },
                    { 51, 185, 175, 117, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/51.png", 157, 139, 55 },
                    { 52, 116, 138, 191, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/52.png", 94, 153, 57 },
                    { 53, 139, 116, 65, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/53.png", 85, 87, 105 },
                    { 54, 181, 181, 169, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/54.png", 112, 109, 199 },
                    { 55, 66, 99, 82, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/55.png", 101, 55, 145 },
                    { 56, 80, 151, 55, "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/56.png", 155, 67, 182 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreateAt" },
                values: new object[] { 1, new DateTime(25, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Deck_CardId",
                table: "Deck",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Deck_GamePlayerId",
                table: "Deck",
                column: "GamePlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_GameId",
                table: "GamePlayers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_PlayerId",
                table: "GamePlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_CardId",
                table: "Moves",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_GamePlayerId",
                table: "Moves",
                column: "GamePlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_RoundId",
                table: "Moves",
                column: "RoundId");

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_GameId",
                table: "Rounds",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "GamePlayers");

            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
