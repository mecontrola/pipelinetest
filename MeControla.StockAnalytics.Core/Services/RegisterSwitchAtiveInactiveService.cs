using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IRegisterSwitchAtiveInactiveService : IBaseEntitySwitchAtiveInactiveService
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class RegisterSwitchAtiveInactiveService(IRegisterRepository registerRepository)
        : BaseEntitySwitchAtiveInactiveService<Register>(registerRepository), IRegisterSwitchAtiveInactiveService
    {
        protected override void ChangeEntity(Register entity)
            => entity.Active = !entity.Active;
    }
}