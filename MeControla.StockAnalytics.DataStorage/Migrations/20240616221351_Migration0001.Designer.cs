﻿// <auto-generated />
using System;
using MeControla.StockAnalytics.DataStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeControla.StockAnalytics.DataStorage.Migrations
{
    [DbContext(typeof(DbAppContext))]
    [Migration("20240616221351_Migration0001")]
    partial class Migration0001
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Broker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("brk_id");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true)
                        .HasColumnName("brk_active");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("brk_created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("brk_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("brk_updated_at");

                    b.Property<Guid>("Uuid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT")
                        .HasColumnName("brk_uuid");

                    b.HasKey("Id");

                    b.ToTable("st_broker", "stocks");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AGORA CTVM S/A",
                            Uuid = new Guid("f299e159-6fd9-49b2-8974-135348fe0089")
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ATIVA INVESTIMENTOS S.A. CTCV",
                            Uuid = new Guid("b11eaebb-0b4d-49e4-bc94-6073bd848bdc")
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BANCO ABN AMRO S/A",
                            Uuid = new Guid("8f2cd243-fa82-45f6-9b86-2795aba772df")
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BANRISUL S/A CVMC",
                            Uuid = new Guid("1d37a7e6-9268-4513-9e7b-5b37f6dc7048")
                        },
                        new
                        {
                            Id = 5L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BB BANCO DE INVESTIMENTO S/A",
                            Uuid = new Guid("1289eb07-540f-4062-b8b2-7df5b7a0d4eb")
                        },
                        new
                        {
                            Id = 6L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BGC LIQUIDEZ DTVM",
                            Uuid = new Guid("69989d35-7780-4faa-bc6f-b85c36170492")
                        },
                        new
                        {
                            Id = 7L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BRADESCO S/A CTVM",
                            Uuid = new Guid("b942cc25-1ea2-4ffc-9ef6-b405a7a84e47")
                        },
                        new
                        {
                            Id = 8L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BTG PACTUAL CTVM S.A.",
                            Uuid = new Guid("5bf959ce-1800-4afa-9daa-74e72e5657a1")
                        },
                        new
                        {
                            Id = 9L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "C6 CTVM LTDA",
                            Uuid = new Guid("8c02c622-8730-46a7-9dc6-5309f275af14")
                        },
                        new
                        {
                            Id = 10L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CITIGROUP GMB CCTVM S.A.",
                            Uuid = new Guid("2b20414f-649f-476d-b7b9-e155ede2a879")
                        },
                        new
                        {
                            Id = 11L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CLEAR CORRETORA - GRUPO XP",
                            Uuid = new Guid("3c610449-f4a6-4d33-a5b4-f38a1d3b78de")
                        },
                        new
                        {
                            Id = 12L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CM CAPITAL MARKETS CCTVM LTDA",
                            Uuid = new Guid("dabb08b5-8cd6-4f7c-8a9e-62365059a80f")
                        },
                        new
                        {
                            Id = 13L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CREDIT SUISSE BRASIL S.A. CTVM",
                            Uuid = new Guid("1bb9146e-d6d8-4037-9354-b71d59de0e71")
                        },
                        new
                        {
                            Id = 14L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GENIAL INSTITUCIONAL CCTVM S.A.",
                            Uuid = new Guid("a881d2a3-64e4-4bcd-b63c-04a05c5507e7")
                        },
                        new
                        {
                            Id = 15L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GENIAL INVESTIMENTOS CVM S.A.",
                            Uuid = new Guid("fd0496f7-7982-4830-8846-ba0e6a00e9ff")
                        },
                        new
                        {
                            Id = 16L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GOLDMAN SACHS DO BRASIL CTVM",
                            Uuid = new Guid("7e134d78-c304-4eed-a8d3-807dbfb2a5f0")
                        },
                        new
                        {
                            Id = 17L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GUIDE INVESTIMENTOS S.A. CV",
                            Uuid = new Guid("ca3a767f-e415-4857-8ba2-c94d1861c36f")
                        },
                        new
                        {
                            Id = 18L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "H.COMMCOR DTVM LTDA",
                            Uuid = new Guid("4290def5-db78-4484-a623-3455c14d9a95")
                        },
                        new
                        {
                            Id = 19L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ICAP DO BRASIL CTVM LTDA",
                            Uuid = new Guid("dd412380-fe3b-4649-aefb-1750bec7a75f")
                        },
                        new
                        {
                            Id = 20L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "IDEAL CTVM SA",
                            Uuid = new Guid("7d9134b8-eb87-445f-87d5-daea82f89e5d")
                        },
                        new
                        {
                            Id = 21L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "INTER DTVM LTDA",
                            Uuid = new Guid("6450d349-19fc-45a5-899f-c54838b03be5")
                        },
                        new
                        {
                            Id = 22L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ITAU CV S/A",
                            Uuid = new Guid("c7f05e7f-7737-4fae-bc1c-71f7d89d50c8")
                        },
                        new
                        {
                            Id = 23L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "J. P. MORGAN CCVM S.A.",
                            Uuid = new Guid("96ae87da-67b9-4980-96ce-bc1b02caabbc")
                        },
                        new
                        {
                            Id = 24L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "LEV DTVM",
                            Uuid = new Guid("d3e535d0-bb0d-45c3-86a4-37c303d21d77")
                        },
                        new
                        {
                            Id = 25L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MERC. DO BRASIL COR. S.A. CTVM",
                            Uuid = new Guid("583452d7-1c1f-462a-b3c8-63b3a93ef478")
                        },
                        new
                        {
                            Id = 26L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MERRILL LYNCH S/A CTVM",
                            Uuid = new Guid("c068840c-2420-4928-8ae3-12b47ec93edf")
                        },
                        new
                        {
                            Id = 27L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MIRAE ASSET WEALTH MANAGEMENT (BRASIL) CCTVM LTDA",
                            Uuid = new Guid("f104d456-b617-4c35-81eb-6a3acf94ed89")
                        },
                        new
                        {
                            Id = 28L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MODAL DTVM LTDA",
                            Uuid = new Guid("28d5199c-46f6-46a6-b713-70ad1d8118e2")
                        },
                        new
                        {
                            Id = 29L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MORGAN STANLEY CTVM S/A",
                            Uuid = new Guid("1e646fa9-8900-4f9e-a059-8d0b0fadbd61")
                        },
                        new
                        {
                            Id = 30L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "NECTON INVESTIMENTOS S.A. CVMC",
                            Uuid = new Guid("dc0b312a-c0d3-4fa5-9b8d-66ddec02e124")
                        },
                        new
                        {
                            Id = 31L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "NOVA FUTURA CTVM LTDA",
                            Uuid = new Guid("7854de37-da11-4c16-b691-41a7a047bdd5")
                        },
                        new
                        {
                            Id = 32L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "NU INVEST CORRETORA DE VALORES S.A",
                            Uuid = new Guid("0843ced1-bef1-47c8-ab14-09f5d05236ee")
                        },
                        new
                        {
                            Id = 33L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ÓRAMA DTVM S.A.",
                            Uuid = new Guid("013cfa38-d2d4-4667-8d29-79fdaa3a383b")
                        },
                        new
                        {
                            Id = 34L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "PLANNER CV S.A",
                            Uuid = new Guid("8287bc3e-e7bd-4649-825c-66cfad5774ed")
                        },
                        new
                        {
                            Id = 35L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "RB CAPITAL DTVM LTDA",
                            Uuid = new Guid("bb2f59b2-f8f0-49b9-9ab0-5e99892c5885")
                        },
                        new
                        {
                            Id = 36L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "RENASCENÇA DTVM LTDA",
                            Uuid = new Guid("c7f7f868-60d6-4308-88d1-9619fb82d5c1")
                        },
                        new
                        {
                            Id = 37L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SAFRA CVC LTDA.",
                            Uuid = new Guid("20306529-bd38-4616-b7d3-bbf2d7be253e")
                        },
                        new
                        {
                            Id = 38L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SANTANDER CCVM S/A",
                            Uuid = new Guid("755e34f9-4369-45a7-93a7-69f2d2d5605e")
                        },
                        new
                        {
                            Id = 39L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SCOTIABANK BRASIL S.A. CTVM",
                            Uuid = new Guid("e35a9eda-7d60-472a-82e7-7d3039afa140")
                        },
                        new
                        {
                            Id = 40L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "STONEX DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA",
                            Uuid = new Guid("987b4ca0-0867-458b-826c-3474e2793f9f")
                        },
                        new
                        {
                            Id = 41L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TERRA INVESTIMENTOS DTVM LTDA",
                            Uuid = new Guid("0760a13d-4658-4e66-858c-371bf4cee77c")
                        },
                        new
                        {
                            Id = 42L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TORO CVTM LTDA",
                            Uuid = new Guid("e24f6ab3-fa76-46e8-99db-835c679885f3")
                        },
                        new
                        {
                            Id = 43L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TULLETT PREBON BRASIL CVC LTDA",
                            Uuid = new Guid("57c3ee3f-3d86-4e3d-9981-c088a593b58e")
                        },
                        new
                        {
                            Id = 44L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "UBS BRASIL CCTVM S/A",
                            Uuid = new Guid("f7175307-644e-498b-93e0-7086c27f2dfb")
                        },
                        new
                        {
                            Id = 45L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "VOTORANTIM CTVM LTDA",
                            Uuid = new Guid("a32270b0-e363-4ea9-8fd1-776e61839b75")
                        },
                        new
                        {
                            Id = 46L,
                            Active = true,
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "XP INVESTIMENTOS CCTVM S/A",
                            Uuid = new Guid("24fcc4d3-9067-4403-b911-09631e5e4f92")
                        });
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cmp_id");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true)
                        .HasColumnName("cmp_active");

                    b.Property<string>("B3Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("cmp_b_3_code");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("cmp_created_at");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("TEXT")
                        .HasColumnName("cmp_document");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("cmp_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("cmp_updated_at");

                    b.Property<Guid>("Uuid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT")
                        .HasColumnName("cmp_uuid");

                    b.HasKey("Id");

                    b.HasIndex("B3Code")
                        .IsUnique();

                    b.ToTable("st_company", "stocks");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Register", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("rgs_id");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true)
                        .HasColumnName("rgs_active");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("rgs_created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("rgs_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("rgs_updated_at");

                    b.Property<Guid>("Uuid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT")
                        .HasColumnName("rgs_uuid");

                    b.Property<string>("Website")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT")
                        .HasColumnName("rgs_website");

                    b.HasKey("Id");

                    b.ToTable("st_register", "stocks");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Ticker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("tck_id");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true)
                        .HasColumnName("tck_active");

                    b.Property<long>("CompanyId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cmp_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("tck_created_at");

                    b.Property<string>("ISINCode")
                        .HasColumnType("TEXT")
                        .HasColumnName("tck_isin_code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("tck_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("tck_updated_at");

                    b.Property<Guid>("Uuid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT")
                        .HasColumnName("tck_uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ISINCode")
                        .IsUnique();

                    b.ToTable("st_ticker", "stocks");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("trn_id");

                    b.Property<uint>("Action")
                        .HasColumnType("INTEGER")
                        .HasColumnName("trn_action");

                    b.Property<long>("Amount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("trn_amount");

                    b.Property<long>("BrokerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("brk_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("trn_created_at");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("trn_date");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnName("trn_price");

                    b.Property<long>("TickerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("tck_id");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT")
                        .HasColumnName("trn_total");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("trn_updated_at");

                    b.Property<Guid>("Uuid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT")
                        .HasColumnName("trn_uuid");

                    b.Property<long>("WalletId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("wll_id");

                    b.HasKey("Id");

                    b.HasIndex("BrokerId");

                    b.HasIndex("TickerId");

                    b.HasIndex("WalletId");

                    b.ToTable("st_transaction", "stocks");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Wallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("wll_id");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true)
                        .HasColumnName("wll_active");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("wll_created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("wll_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("wll_updated_at");

                    b.Property<Guid>("Uuid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT")
                        .HasColumnName("wll_uuid");

                    b.HasKey("Id");

                    b.ToTable("st_wallet", "stocks");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Ticker", b =>
                {
                    b.HasOne("MeControla.StockAnalytics.Data.Entities.Company", "Company")
                        .WithMany("Tickers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Transaction", b =>
                {
                    b.HasOne("MeControla.StockAnalytics.Data.Entities.Broker", "Broker")
                        .WithMany()
                        .HasForeignKey("BrokerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeControla.StockAnalytics.Data.Entities.Ticker", "Ticker")
                        .WithMany()
                        .HasForeignKey("TickerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeControla.StockAnalytics.Data.Entities.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Broker");

                    b.Navigation("Ticker");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("MeControla.StockAnalytics.Data.Entities.Company", b =>
                {
                    b.Navigation("Tickers");
                });
#pragma warning restore 612, 618
        }
    }
}
