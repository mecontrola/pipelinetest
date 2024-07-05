using MeControla.Core.Data.Entities;
using System;
using System.Collections.Generic;

namespace MeControla.StockAnalytics.Data.Entities
{
    public class Stock : IModificationDateTimeEntity
    {
        public long Id { get; set; }
        public Guid Uuid { get; set; }
        public int Amount { get; set; }
        public decimal AverageValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long TickerId { get; set; }
        public Ticker Ticker { get; set; }
        public long WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public IList<Transaction> Transactions { get; set; }
    }
}