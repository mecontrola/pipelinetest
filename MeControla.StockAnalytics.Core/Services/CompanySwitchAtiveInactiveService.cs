using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ICompanySwitchAtiveInactiveService : IBaseEntitySwitchAtiveInactiveService
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanySwitchAtiveInactiveService(ICompanyRepository companyRepository)
        : BaseEntitySwitchAtiveInactiveService<Company>(companyRepository), ICompanySwitchAtiveInactiveService
    {
        protected override void ChangeEntity(Company entity)
            => entity.Active = !entity.Active;
    }
}