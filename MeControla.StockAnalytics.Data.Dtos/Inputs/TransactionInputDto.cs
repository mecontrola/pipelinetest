using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos.Inputs
{
    public class TransactionInputDto : IInputDto
    {
        public Guid BrokerId { get; set; }
        public Guid TickerId { get; set; }
        public Guid WalletId { get; set; }
        public DateTime Date { get; set; }
        public bool IsBuy { get; set; }
        public long Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}