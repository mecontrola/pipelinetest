using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos.FilterInputs
{
    public class TransactionFilterInputDto : IInputDto
    {
        public Guid? BrokerId { get; set; }
        public Guid? TickerId { get; set; }
        public Guid? WalletId { get; set; }
        public bool? IsBuy { get; set; }
    }
}