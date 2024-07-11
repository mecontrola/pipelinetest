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
    sealed class CompanyBuilder : BaseBuilder<CompanyBuilder, Company>, IBuilder<Company>
    {
        protected override void FillDefaultValues(Company obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
            obj.Active = true;
        }

        public CompanyBuilder SetName(string value)
            => Set(obj => obj.Name = value);

        public CompanyBuilder SetB3Code(string value)
            => Set(obj => obj.B3Code = value);

        public CompanyBuilder SetDocument(string value)
            => Set(obj => obj.Document = value);
    }
}