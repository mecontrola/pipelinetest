using MeControla.Core.Data.Entities;
using MeControla.StockAnalytics.Data.Enums;
using System;

namespace MeControla.StockAnalytics.Data.Entities
{
    public class Transaction : IModificationDateTimeEntity
    {
        public long Id { get; set; }
        public Guid Uuid { get; set; }
        public DateTime Date { get; set; }
        public TransactionAction Action { get; set; }
        public long Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long BrokerId { get; set; }
        public Broker Broker { get; set; }
        public long TickerId { get; set; }
        public Ticker Ticker { get; set; }
        public long WalletId { get; set; }
        public Wallet Wallet { get; set; }
    }
}