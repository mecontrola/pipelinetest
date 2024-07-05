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
    sealed class TransactionBuilder : BaseBuilder<TransactionBuilder, Transaction>, IBuilder<Transaction>
    {
        protected override void FillDefaultValues(Transaction obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
        }
    }
}