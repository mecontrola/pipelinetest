using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Core.Validators;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IBrokerSaveService : IBaseEntitySaveService<BrokerInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerSaveService(IBrokerRepository brokerRepository,
                                   IBrokerInputDtoValidator brokerInputDtoValidator)
        : BaseEntitySaveService<Broker, BrokerInputDto>(brokerRepository, brokerInputDtoValidator), IBrokerSaveService
    {
        protected override void FillEntity(Broker entity, BrokerInputDto input)
        {
            entity.Name = input.Name;

            if (entity.Id == 0)
                entity.Active = true;
        }

        protected override Broker BuildEntity()
            => BrokerBuilder.GetInstance().ToBuild();
    }
}