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
    sealed class WalletBuilder : BaseBuilder<WalletBuilder, Wallet>, IBuilder<Wallet>
    {
        protected override void FillDefaultValues(Wallet obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
        }
    }
}