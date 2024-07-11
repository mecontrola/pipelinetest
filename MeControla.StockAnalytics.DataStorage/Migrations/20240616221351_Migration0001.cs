using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeControla.StockAnalytics.DataStorage.Migrations
{
    /// <inheritdoc />
    public partial class Migration0001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "stocks");

            migrationBuilder.CreateTable(
                name: "st_broker",
                schema: "stocks",
                columns: table => new
                {
                    brk_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    brk_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    brk_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    brk_active = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    brk_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    brk_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_broker", x => x.brk_id);
                });

            migrationBuilder.CreateTable(
                name: "st_company",
                schema: "stocks",
                columns: table => new
                {
                    cmp_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cmp_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    cmp_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    cmp_b_3_code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    cmp_document = table.Column<string>(type: "TEXT", maxLength: 18, nullable: false),
                    cmp_active = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    cmp_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cmp_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_company", x => x.cmp_id);
                });

            migrationBuilder.CreateTable(
                name: "st_register",
                schema: "stocks",
                columns: table => new
                {
                    rgs_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rgs_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    rgs_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    rgs_website = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    rgs_active = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    rgs_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    rgs_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_register", x => x.rgs_id);
                });

            migrationBuilder.CreateTable(
                name: "st_wallet",
                schema: "stocks",
                columns: table => new
                {
                    wll_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    wll_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    wll_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    wll_active = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    wll_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    wll_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_wallet", x => x.wll_id);
                });

            migrationBuilder.CreateTable(
                name: "st_ticker",
                schema: "stocks",
                columns: table => new
                {
                    tck_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    tck_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    tck_name = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    tck_isin_code = table.Column<string>(type: "TEXT", nullable: true),
                    tck_active = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    tck_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    tck_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    cmp_id = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_ticker", x => x.tck_id);
                    table.ForeignKey(
                        name: "FK_st_ticker_st_company_cmp_id",
                        column: x => x.cmp_id,
                        principalSchema: "stocks",
                        principalTable: "st_company",
                        principalColumn: "cmp_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "st_transaction",
                schema: "stocks",
                columns: table => new
                {
                    trn_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    trn_uuid = table.Column<Guid>(type: "TEXT", maxLength: 36, nullable: false),
                    trn_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    trn_action = table.Column<uint>(type: "INTEGER", nullable: false),
                    trn_amount = table.Column<long>(type: "INTEGER", nullable: false),
                    trn_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    trn_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    trn_created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    trn_updated_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    brk_id = table.Column<long>(type: "INTEGER", nullable: false),
                    tck_id = table.Column<long>(type: "INTEGER", nullable: false),
                    wll_id = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_st_transaction", x => x.trn_id);
                    table.ForeignKey(
                        name: "FK_st_transaction_st_broker_brk_id",
                        column: x => x.brk_id,
                        principalSchema: "stocks",
                        principalTable: "st_broker",
                        principalColumn: "brk_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_st_transaction_st_ticker_tck_id",
                        column: x => x.tck_id,
                        principalSchema: "stocks",
                        principalTable: "st_ticker",
                        principalColumn: "tck_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_st_transaction_st_wallet_wll_id",
                        column: x => x.wll_id,
                        principalSchema: "stocks",
                        principalTable: "st_wallet",
                        principalColumn: "wll_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "stocks",
                table: "st_broker",
                columns: new[] { "brk_id", "brk_active", "brk_created_at", "brk_name", "brk_updated_at", "brk_uuid" },
                values: new object[,]
                {
                    { 1L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AGORA CTVM S/A", null, new Guid("f299e159-6fd9-49b2-8974-135348fe0089") },
                    { 2L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ATIVA INVESTIMENTOS S.A. CTCV", null, new Guid("b11eaebb-0b4d-49e4-bc94-6073bd848bdc") },
                    { 3L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BANCO ABN AMRO S/A", null, new Guid("8f2cd243-fa82-45f6-9b86-2795aba772df") },
                    { 4L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BANRISUL S/A CVMC", null, new Guid("1d37a7e6-9268-4513-9e7b-5b37f6dc7048") },
                    { 5L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB BANCO DE INVESTIMENTO S/A", null, new Guid("1289eb07-540f-4062-b8b2-7df5b7a0d4eb") },
                    { 6L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BGC LIQUIDEZ DTVM", null, new Guid("69989d35-7780-4faa-bc6f-b85c36170492") },
                    { 7L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BRADESCO S/A CTVM", null, new Guid("b942cc25-1ea2-4ffc-9ef6-b405a7a84e47") },
                    { 8L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTG PACTUAL CTVM S.A.", null, new Guid("5bf959ce-1800-4afa-9daa-74e72e5657a1") },
                    { 9L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6 CTVM LTDA", null, new Guid("8c02c622-8730-46a7-9dc6-5309f275af14") },
                    { 10L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CITIGROUP GMB CCTVM S.A.", null, new Guid("2b20414f-649f-476d-b7b9-e155ede2a879") },
                    { 11L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLEAR CORRETORA - GRUPO XP", null, new Guid("3c610449-f4a6-4d33-a5b4-f38a1d3b78de") },
                    { 12L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CM CAPITAL MARKETS CCTVM LTDA", null, new Guid("dabb08b5-8cd6-4f7c-8a9e-62365059a80f") },
                    { 13L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CREDIT SUISSE BRASIL S.A. CTVM", null, new Guid("1bb9146e-d6d8-4037-9354-b71d59de0e71") },
                    { 14L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GENIAL INSTITUCIONAL CCTVM S.A.", null, new Guid("a881d2a3-64e4-4bcd-b63c-04a05c5507e7") },
                    { 15L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GENIAL INVESTIMENTOS CVM S.A.", null, new Guid("fd0496f7-7982-4830-8846-ba0e6a00e9ff") },
                    { 16L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GOLDMAN SACHS DO BRASIL CTVM", null, new Guid("7e134d78-c304-4eed-a8d3-807dbfb2a5f0") },
                    { 17L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GUIDE INVESTIMENTOS S.A. CV", null, new Guid("ca3a767f-e415-4857-8ba2-c94d1861c36f") },
                    { 18L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "H.COMMCOR DTVM LTDA", null, new Guid("4290def5-db78-4484-a623-3455c14d9a95") },
                    { 19L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ICAP DO BRASIL CTVM LTDA", null, new Guid("dd412380-fe3b-4649-aefb-1750bec7a75f") },
                    { 20L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IDEAL CTVM SA", null, new Guid("7d9134b8-eb87-445f-87d5-daea82f89e5d") },
                    { 21L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTER DTVM LTDA", null, new Guid("6450d349-19fc-45a5-899f-c54838b03be5") },
                    { 22L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ITAU CV S/A", null, new Guid("c7f05e7f-7737-4fae-bc1c-71f7d89d50c8") },
                    { 23L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "J. P. MORGAN CCVM S.A.", null, new Guid("96ae87da-67b9-4980-96ce-bc1b02caabbc") },
                    { 24L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LEV DTVM", null, new Guid("d3e535d0-bb0d-45c3-86a4-37c303d21d77") },
                    { 25L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MERC. DO BRASIL COR. S.A. CTVM", null, new Guid("583452d7-1c1f-462a-b3c8-63b3a93ef478") },
                    { 26L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MERRILL LYNCH S/A CTVM", null, new Guid("c068840c-2420-4928-8ae3-12b47ec93edf") },
                    { 27L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MIRAE ASSET WEALTH MANAGEMENT (BRASIL) CCTVM LTDA", null, new Guid("f104d456-b617-4c35-81eb-6a3acf94ed89") },
                    { 28L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MODAL DTVM LTDA", null, new Guid("28d5199c-46f6-46a6-b713-70ad1d8118e2") },
                    { 29L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MORGAN STANLEY CTVM S/A", null, new Guid("1e646fa9-8900-4f9e-a059-8d0b0fadbd61") },
                    { 30L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NECTON INVESTIMENTOS S.A. CVMC", null, new Guid("dc0b312a-c0d3-4fa5-9b8d-66ddec02e124") },
                    { 31L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NOVA FUTURA CTVM LTDA", null, new Guid("7854de37-da11-4c16-b691-41a7a047bdd5") },
                    { 32L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NU INVEST CORRETORA DE VALORES S.A", null, new Guid("0843ced1-bef1-47c8-ab14-09f5d05236ee") },
                    { 33L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ÓRAMA DTVM S.A.", null, new Guid("013cfa38-d2d4-4667-8d29-79fdaa3a383b") },
                    { 34L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PLANNER CV S.A", null, new Guid("8287bc3e-e7bd-4649-825c-66cfad5774ed") },
                    { 35L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RB CAPITAL DTVM LTDA", null, new Guid("bb2f59b2-f8f0-49b9-9ab0-5e99892c5885") },
                    { 36L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RENASCENÇA DTVM LTDA", null, new Guid("c7f7f868-60d6-4308-88d1-9619fb82d5c1") },
                    { 37L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAFRA CVC LTDA.", null, new Guid("20306529-bd38-4616-b7d3-bbf2d7be253e") },
                    { 38L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SANTANDER CCVM S/A", null, new Guid("755e34f9-4369-45a7-93a7-69f2d2d5605e") },
                    { 39L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTIABANK BRASIL S.A. CTVM", null, new Guid("e35a9eda-7d60-472a-82e7-7d3039afa140") },
                    { 40L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "STONEX DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA", null, new Guid("987b4ca0-0867-458b-826c-3474e2793f9f") },
                    { 41L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TERRA INVESTIMENTOS DTVM LTDA", null, new Guid("0760a13d-4658-4e66-858c-371bf4cee77c") },
                    { 42L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TORO CVTM LTDA", null, new Guid("e24f6ab3-fa76-46e8-99db-835c679885f3") },
                    { 43L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TULLETT PREBON BRASIL CVC LTDA", null, new Guid("57c3ee3f-3d86-4e3d-9981-c088a593b58e") },
                    { 44L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UBS BRASIL CCTVM S/A", null, new Guid("f7175307-644e-498b-93e0-7086c27f2dfb") },
                    { 45L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VOTORANTIM CTVM LTDA", null, new Guid("a32270b0-e363-4ea9-8fd1-776e61839b75") },
                    { 46L, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "XP INVESTIMENTOS CCTVM S/A", null, new Guid("24fcc4d3-9067-4403-b911-09631e5e4f92") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_st_company_cmp_b_3_code",
                schema: "stocks",
                table: "st_company",
                column: "cmp_b_3_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_st_ticker_cmp_id",
                schema: "stocks",
                table: "st_ticker",
                column: "cmp_id");

            migrationBuilder.CreateIndex(
                name: "IX_st_ticker_tck_isin_code",
                schema: "stocks",
                table: "st_ticker",
                column: "tck_isin_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_st_transaction_brk_id",
                schema: "stocks",
                table: "st_transaction",
                column: "brk_id");

            migrationBuilder.CreateIndex(
                name: "IX_st_transaction_tck_id",
                schema: "stocks",
                table: "st_transaction",
                column: "tck_id");

            migrationBuilder.CreateIndex(
                name: "IX_st_transaction_wll_id",
                schema: "stocks",
                table: "st_transaction",
                column: "wll_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "st_register",
                schema: "stocks");

            migrationBuilder.DropTable(
                name: "st_transaction",
                schema: "stocks");

            migrationBuilder.DropTable(
                name: "st_broker",
                schema: "stocks");

            migrationBuilder.DropTable(
                name: "st_ticker",
                schema: "stocks");

            migrationBuilder.DropTable(
                name: "st_wallet",
                schema: "stocks");

            migrationBuilder.DropTable(
                name: "st_company",
                schema: "stocks");
        }
    }
}
