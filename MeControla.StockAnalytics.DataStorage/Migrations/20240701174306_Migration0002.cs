using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeControla.StockAnalytics.DataStorage.Migrations
{
    /// <inheritdoc />
    public partial class Migration0002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "st_consolidated",
                schema: "stocks",
                columns: table => new
                {
                    cns_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cns_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    cns_amount = table.Column<long>(type: "INTEGER", nullable: false),
                    cns_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    cns_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    cns_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cns_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    tck_id = table.Column<long>(type: "INTEGER", nullable: false),
                    wll_id = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_consolidated", x => x.cns_id);
                    table.ForeignKey(
                        name: "FK_st_consolidated_st_ticker_tck_id",
                        column: x => x.tck_id,
                        principalSchema: "stocks",
                        principalTable: "st_ticker",
                        principalColumn: "tck_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_st_consolidated_st_wallet_wll_id",
                        column: x => x.wll_id,
                        principalSchema: "stocks",
                        principalTable: "st_wallet",
                        principalColumn: "wll_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_st_consolidated_tck_id",
                schema: "stocks",
                table: "st_consolidated",
                column: "tck_id");

            migrationBuilder.CreateIndex(
                name: "IX_st_consolidated_wll_id",
                schema: "stocks",
                table: "st_consolidated",
                column: "wll_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "st_consolidated",
                schema: "stocks");
        }
    }
}
