using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos
{
    public class WalletLiteDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}