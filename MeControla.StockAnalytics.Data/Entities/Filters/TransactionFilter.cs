using MeControla.Core.Data.Entities;
using MeControla.StockAnalytics.Data.Enums;
using System;

namespace MeControla.StockAnalytics.Data.Entities.Filters
{
    public class TransactionFilter : IFilterEntity
    {
        public Guid? BrokerId { get; set; }
        public Guid? TickerId { get; set; }
        public Guid? WalletId { get; set; }
        public TransactionAction? Action { get; set; }
    }
}