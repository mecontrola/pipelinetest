using MeControla.Core.Data.Entities;
using System;

namespace MeControla.StockAnalytics.Data.Entities
{
    public class Register : IModificationDateTimeEntity
    {
        public long Id { get; set; }
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}