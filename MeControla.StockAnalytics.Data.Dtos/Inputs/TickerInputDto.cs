using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos.Inputs
{
    public class TickerInputDto : IInputDto
    {
        public string Name { get; set; }
        public string ISINCode { get; set; }
        public Guid CompanyId { get; set; }
    }
}