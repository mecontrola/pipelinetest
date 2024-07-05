using MeControla.Core.Builders;
using MeControla.StockAnalytics.Data.Entities;
using System;

namespace MeControla.StockAnalytics.Core.Builders
{
#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerBuilder : BaseBuilder<TickerBuilder, Ticker>, IBuilder<Ticker>
    {
        protected override void FillDefaultValues(Ticker obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
            obj.Active = true;
        }

        public TickerBuilder SetName(string value)
            => Set(obj => obj.Name = value);

        public TickerBuilder SetISINCode(string value)
            => Set(obj => obj.ISINCode = value);

        public TickerBuilder SetCompanyId(long value)
            => Set(obj => obj.CompanyId = value);
    }
}