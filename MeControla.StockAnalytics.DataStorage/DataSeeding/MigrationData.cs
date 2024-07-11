using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MeControla.StockAnalytics.DataStorage.DataSeeding
{
    public static class MigrationData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broker>().HasData(
                new Broker { Id = 1, Uuid = Guid.Parse("F299E159-6FD9-49B2-8974-135348FE0089"), Name = "AGORA CTVM S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 2, Uuid = Guid.Parse("B11EAEBB-0B4D-49E4-BC94-6073BD848BDC"), Name = "ATIVA INVESTIMENTOS S.A. CTCV", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 3, Uuid = Guid.Parse("8F2CD243-FA82-45F6-9B86-2795ABA772DF"), Name = "BANCO ABN AMRO S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 4, Uuid = Guid.Parse("1D37A7E6-9268-4513-9E7B-5B37F6DC7048"), Name = "BANRISUL S/A CVMC", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 5, Uuid = Guid.Parse("1289EB07-540F-4062-B8B2-7DF5B7A0D4EB"), Name = "BB BANCO DE INVESTIMENTO S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 6, Uuid = Guid.Parse("69989D35-7780-4FAA-BC6F-B85C36170492"), Name = "BGC LIQUIDEZ DTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 7, Uuid = Guid.Parse("B942CC25-1EA2-4FFC-9EF6-B405A7A84E47"), Name = "BRADESCO S/A CTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 8, Uuid = Guid.Parse("5BF959CE-1800-4AFA-9DAA-74E72E5657A1"), Name = "BTG PACTUAL CTVM S.A.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 9, Uuid = Guid.Parse("8C02C622-8730-46A7-9DC6-5309F275AF14"), Name = "C6 CTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 10, Uuid = Guid.Parse("2B20414F-649F-476D-B7B9-E155EDE2A879"), Name = "CITIGROUP GMB CCTVM S.A.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 11, Uuid = Guid.Parse("3C610449-F4A6-4D33-A5B4-F38A1D3B78DE"), Name = "CLEAR CORRETORA - GRUPO XP", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 12, Uuid = Guid.Parse("DABB08B5-8CD6-4F7C-8A9E-62365059A80F"), Name = "CM CAPITAL MARKETS CCTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 13, Uuid = Guid.Parse("1BB9146E-D6D8-4037-9354-B71D59DE0E71"), Name = "CREDIT SUISSE BRASIL S.A. CTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 14, Uuid = Guid.Parse("A881D2A3-64E4-4BCD-B63C-04A05C5507E7"), Name = "GENIAL INSTITUCIONAL CCTVM S.A.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 15, Uuid = Guid.Parse("FD0496F7-7982-4830-8846-BA0E6A00E9FF"), Name = "GENIAL INVESTIMENTOS CVM S.A.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 16, Uuid = Guid.Parse("7E134D78-C304-4EED-A8D3-807DBFB2A5F0"), Name = "GOLDMAN SACHS DO BRASIL CTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 17, Uuid = Guid.Parse("CA3A767F-E415-4857-8BA2-C94D1861C36F"), Name = "GUIDE INVESTIMENTOS S.A. CV", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 18, Uuid = Guid.Parse("4290DEF5-DB78-4484-A623-3455C14D9A95"), Name = "H.COMMCOR DTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 19, Uuid = Guid.Parse("DD412380-FE3B-4649-AEFB-1750BEC7A75F"), Name = "ICAP DO BRASIL CTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 20, Uuid = Guid.Parse("7D9134B8-EB87-445F-87D5-DAEA82F89E5D"), Name = "IDEAL CTVM SA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 21, Uuid = Guid.Parse("6450D349-19FC-45A5-899F-C54838B03BE5"), Name = "INTER DTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 22, Uuid = Guid.Parse("C7F05E7F-7737-4FAE-BC1C-71F7D89D50C8"), Name = "ITAU CV S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 23, Uuid = Guid.Parse("96AE87DA-67B9-4980-96CE-BC1B02CAABBC"), Name = "J. P. MORGAN CCVM S.A.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 24, Uuid = Guid.Parse("D3E535D0-BB0D-45C3-86A4-37C303D21D77"), Name = "LEV DTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 25, Uuid = Guid.Parse("583452D7-1C1F-462A-B3C8-63B3A93EF478"), Name = "MERC. DO BRASIL COR. S.A. CTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 26, Uuid = Guid.Parse("C068840C-2420-4928-8AE3-12B47EC93EDF"), Name = "MERRILL LYNCH S/A CTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 27, Uuid = Guid.Parse("F104D456-B617-4C35-81EB-6A3ACF94ED89"), Name = "MIRAE ASSET WEALTH MANAGEMENT (BRASIL) CCTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 28, Uuid = Guid.Parse("28D5199C-46F6-46A6-B713-70AD1D8118E2"), Name = "MODAL DTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 29, Uuid = Guid.Parse("1E646FA9-8900-4F9E-A059-8D0B0FADBD61"), Name = "MORGAN STANLEY CTVM S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 30, Uuid = Guid.Parse("DC0B312A-C0D3-4FA5-9B8D-66DDEC02E124"), Name = "NECTON INVESTIMENTOS S.A. CVMC", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 31, Uuid = Guid.Parse("7854DE37-DA11-4C16-B691-41A7A047BDD5"), Name = "NOVA FUTURA CTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 32, Uuid = Guid.Parse("0843CED1-BEF1-47C8-AB14-09F5D05236EE"), Name = "NU INVEST CORRETORA DE VALORES S.A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 33, Uuid = Guid.Parse("013CFA38-D2D4-4667-8D29-79FDAA3A383B"), Name = "ÓRAMA DTVM S.A.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 34, Uuid = Guid.Parse("8287BC3E-E7BD-4649-825C-66CFAD5774ED"), Name = "PLANNER CV S.A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 35, Uuid = Guid.Parse("BB2F59B2-F8F0-49B9-9AB0-5E99892C5885"), Name = "RB CAPITAL DTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 36, Uuid = Guid.Parse("C7F7F868-60D6-4308-88D1-9619FB82D5C1"), Name = "RENASCENÇA DTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 37, Uuid = Guid.Parse("20306529-BD38-4616-B7D3-BBF2D7BE253E"), Name = "SAFRA CVC LTDA.", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 38, Uuid = Guid.Parse("755E34F9-4369-45A7-93A7-69F2D2D5605E"), Name = "SANTANDER CCVM S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 39, Uuid = Guid.Parse("E35A9EDA-7D60-472A-82E7-7D3039AFA140"), Name = "SCOTIABANK BRASIL S.A. CTVM", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 40, Uuid = Guid.Parse("987B4CA0-0867-458B-826C-3474E2793F9F"), Name = "STONEX DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 41, Uuid = Guid.Parse("0760A13D-4658-4E66-858C-371BF4CEE77C"), Name = "TERRA INVESTIMENTOS DTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 42, Uuid = Guid.Parse("E24F6AB3-FA76-46E8-99DB-835C679885F3"), Name = "TORO CVTM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 43, Uuid = Guid.Parse("57C3EE3F-3D86-4E3D-9981-C088A593B58E"), Name = "TULLETT PREBON BRASIL CVC LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 44, Uuid = Guid.Parse("F7175307-644E-498B-93E0-7086C27F2DFB"), Name = "UBS BRASIL CCTVM S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 45, Uuid = Guid.Parse("A32270B0-E363-4EA9-8FD1-776E61839B75"), Name = "VOTORANTIM CTVM LTDA", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null },
                new Broker { Id = 46, Uuid = Guid.Parse("24FCC4D3-9067-4403-B911-09631E5E4F92"), Name = "XP INVESTIMENTOS CCTVM S/A", Active = true, CreatedAt = new DateTime(2024, 1, 1), UpdatedAt = null }
            );
        }
    }
}