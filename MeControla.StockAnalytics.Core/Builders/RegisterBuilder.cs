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
    sealed class RegisterBuilder : BaseBuilder<RegisterBuilder, Register>, IBuilder<Register>
    {
        protected override void FillDefaultValues(Register obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
        }
    }
}