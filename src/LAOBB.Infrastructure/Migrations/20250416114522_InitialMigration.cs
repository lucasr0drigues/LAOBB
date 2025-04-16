using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAOBB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SbiId = table.Column<int>(type: "integer", nullable: true),
                    StartTime = table.Column<string>(type: "text", nullable: true),
                    EndTime = table.Column<string>(type: "text", nullable: true),
                    Timeout = table.Column<string>(type: "text", nullable: true),
                    TotalFame = table.Column<int>(type: "integer", nullable: true),
                    TotalKills = table.Column<int>(type: "integer", nullable: true),
                    ClusterName = table.Column<string>(type: "text", nullable: false),
                    BattleTimeout = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllianceBattles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BattleId = table.Column<Guid>(type: "uuid", nullable: false),
                    AllianceId = table.Column<Guid>(type: "uuid", nullable: false),
                    SbiAllianceId = table.Column<string>(type: "text", nullable: false),
                    AllianceTag = table.Column<string>(type: "text", nullable: false),
                    Kills = table.Column<int>(type: "integer", nullable: true),
                    Deaths = table.Column<int>(type: "integer", nullable: true),
                    KillFame = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllianceBattles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllianceBattles_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alliances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SbiAllianceId = table.Column<string>(type: "text", nullable: false),
                    AllianceName = table.Column<string>(type: "text", nullable: false),
                    AllianceTag = table.Column<string>(type: "text", nullable: false),
                    FounderId = table.Column<Guid>(type: "uuid", nullable: true),
                    SbiFounderId = table.Column<string>(type: "text", nullable: true),
                    FounderName = table.Column<string>(type: "text", nullable: true),
                    Founded = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NumPlayers = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alliances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuildBattles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BattleId = table.Column<Guid>(type: "uuid", nullable: false),
                    GuildId = table.Column<Guid>(type: "uuid", nullable: false),
                    SbiGuildId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Kills = table.Column<int>(type: "integer", nullable: true),
                    Deaths = table.Column<int>(type: "integer", nullable: true),
                    KillFame = table.Column<int>(type: "integer", nullable: true),
                    AllianceId = table.Column<Guid>(type: "uuid", nullable: true),
                    AllianceTag = table.Column<string>(type: "text", nullable: true),
                    SbiAllianceId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildBattles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuildBattles_Alliances_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_GuildBattles_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SbiId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FounderId = table.Column<Guid>(type: "uuid", nullable: true),
                    SbiFounderId = table.Column<string>(type: "text", nullable: true),
                    FounderName = table.Column<string>(type: "text", nullable: true),
                    Founded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AllianceTag = table.Column<string>(type: "text", nullable: true),
                    AllianceId = table.Column<Guid>(type: "uuid", nullable: true),
                    SbiAllianceId = table.Column<string>(type: "text", nullable: true),
                    AllianceName = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    KillFame = table.Column<long>(type: "bigint", nullable: true),
                    DeathFame = table.Column<long>(type: "bigint", nullable: true),
                    AttacksWon = table.Column<int>(type: "integer", nullable: true),
                    DefensesWon = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guilds_Alliances_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SbiId = table.Column<string>(type: "text", nullable: false),
                    GuildId = table.Column<Guid>(type: "uuid", nullable: true),
                    GuildName = table.Column<string>(type: "text", nullable: true),
                    SbiGuildId = table.Column<string>(type: "text", nullable: true),
                    AllianceId = table.Column<Guid>(type: "uuid", nullable: true),
                    AllianceName = table.Column<string>(type: "text", nullable: true),
                    SbiAllianceId = table.Column<string>(type: "text", nullable: true),
                    AllianceTag = table.Column<string>(type: "text", nullable: true),
                    Avatar = table.Column<string>(type: "text", nullable: true),
                    AvatarRing = table.Column<string>(type: "text", nullable: true),
                    DeathFame = table.Column<int>(type: "integer", nullable: true),
                    KillFame = table.Column<int>(type: "integer", nullable: true),
                    FameRatio = table.Column<double>(type: "double precision", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Alliances_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Players_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "PlayerBattles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BattleId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uuid", nullable: false),
                    SbiPlayerId = table.Column<string>(type: "text", nullable: true),
                    PlayerName = table.Column<string>(type: "text", nullable: false),
                    Kills = table.Column<int>(type: "integer", nullable: true),
                    Deaths = table.Column<int>(type: "integer", nullable: true),
                    KillFame = table.Column<int>(type: "integer", nullable: true),
                    GuildId = table.Column<Guid>(type: "uuid", nullable: true),
                    GuildName = table.Column<string>(type: "text", nullable: true),
                    SbiGuildId = table.Column<string>(type: "text", nullable: true),
                    AllianceId = table.Column<Guid>(type: "uuid", nullable: true),
                    AllianceTag = table.Column<string>(type: "text", nullable: true),
                    SbiAllianceId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerBattles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerBattles_Alliances_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PlayerBattles_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerBattles_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PlayerBattles_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllianceBattles_AllianceId",
                table: "AllianceBattles",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_AllianceBattles_BattleId",
                table: "AllianceBattles",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Alliances_FounderId",
                table: "Alliances",
                column: "FounderId");

            migrationBuilder.CreateIndex(
                name: "IX_Alliances_SbiAllianceId",
                table: "Alliances",
                column: "SbiAllianceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Battles_SbiId",
                table: "Battles",
                column: "SbiId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildBattles_AllianceId",
                table: "GuildBattles",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildBattles_BattleId",
                table: "GuildBattles",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildBattles_GuildId",
                table: "GuildBattles",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Guilds_AllianceId",
                table: "Guilds",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guilds_FounderId",
                table: "Guilds",
                column: "FounderId");

            migrationBuilder.CreateIndex(
                name: "IX_Guilds_SbiId",
                table: "Guilds",
                column: "SbiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBattles_AllianceId",
                table: "PlayerBattles",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBattles_BattleId",
                table: "PlayerBattles",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBattles_GuildId",
                table: "PlayerBattles",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBattles_PlayerId",
                table: "PlayerBattles",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_AllianceId",
                table: "Players",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GuildId",
                table: "Players",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_SbiId",
                table: "Players",
                column: "SbiId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllianceBattles_Alliances_AllianceId",
                table: "AllianceBattles",
                column: "AllianceId",
                principalTable: "Alliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alliances_Players_FounderId",
                table: "Alliances",
                column: "FounderId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_GuildBattles_Guilds_GuildId",
                table: "GuildBattles",
                column: "GuildId",
                principalTable: "Guilds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guilds_Players_FounderId",
                table: "Guilds",
                column: "FounderId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guilds_Alliances_AllianceId",
                table: "Guilds");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Alliances_AllianceId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Guilds_Players_FounderId",
                table: "Guilds");

            migrationBuilder.DropTable(
                name: "AllianceBattles");

            migrationBuilder.DropTable(
                name: "GuildBattles");

            migrationBuilder.DropTable(
                name: "PlayerBattles");

            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "Alliances");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Guilds");
        }
    }
}
