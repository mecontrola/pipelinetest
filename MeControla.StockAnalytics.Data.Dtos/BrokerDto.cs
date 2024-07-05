using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos
{
    public class BrokerDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}