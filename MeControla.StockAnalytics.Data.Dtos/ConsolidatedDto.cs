using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos
{
    public class ConsolidatedDto : IDto
    {
        public Guid Id { get; set; }
        public TickerLiteDto Ticker { get; set; }
        public WalletLiteDto Wallet { get; set; }
        public long Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}