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
    sealed class BrokerBuilder : BaseBuilder<BrokerBuilder, Broker>, IBuilder<Broker>
    {
        protected override void FillDefaultValues(Broker obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
            obj.Active = true;
        }

        public BrokerBuilder SetName(string value)
            => Set(obj => obj.Name = value);
    }
}