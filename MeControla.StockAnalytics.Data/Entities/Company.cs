using MeControla.Core.Data.Entities;
using System;
using System.Collections.Generic;

namespace MeControla.StockAnalytics.Data.Entities
{
    public class Company : IModificationDateTimeEntity
    {
        public long Id { get; set; }
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string B3Code { get; set; }
        public string Document { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public IList<Ticker> Tickers { get; set; }
    }
}