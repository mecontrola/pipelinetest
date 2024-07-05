using MeControla.Core.Data.Entities;

namespace MeControla.StockAnalytics.Data.Entities.Filters
{
    public class StockFilter : IFilterEntity
    {
        public string Name { get; set; }
        public bool? Active { get; set; }
    }
}