using MeControla.Core.Data.Entities;
using System;

namespace MeControla.StockAnalytics.Data.Entities
{
    public class Dividend : IModificationDateTimeEntity
    {
        public long Id { get; set; }
        public Guid Uuid { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long StockId { get; set; }
        public Stock Stock{ get; set; }
    }
}