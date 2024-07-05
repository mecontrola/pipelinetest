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
    sealed class ConsolidatedBuilder : BaseBuilder<ConsolidatedBuilder, Consolidated>, IBuilder<Consolidated>
    {
        protected override void FillDefaultValues(Consolidated obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
        }

        public ConsolidatedBuilder SetTickerId(long value)
            => Set(obj => obj.TickerId = value);

        public ConsolidatedBuilder SetWalletId(long value)
            => Set(obj => obj.WalletId = value);
    }
}