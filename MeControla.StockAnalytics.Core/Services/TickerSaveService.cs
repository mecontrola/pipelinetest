using MeControla.Core.Exceptions;
using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Core.Validators;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System;
using System.Threading;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITickerSaveService : IBaseEntitySaveService<TickerInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerSaveService(ICompanyRepository companyRepository,
                                   ITickerRepository tickerRepository,
                                   ITickerInputDtoValidator registerInputDtoValidator)
        : BaseEntitySaveService<Ticker, TickerInputDto>(tickerRepository, registerInputDtoValidator), ITickerSaveService
    {
        protected override void FillEntity(Ticker entity, TickerInputDto input)
        {
            entity.Name = input.Name;
            entity.ISINCode = input.ISINCode;
            entity.CompanyId = FindCompanyIdByUuid(input.CompanyId);

            if (entity.Id == 0)
                entity.Active = true;
        }
        private long FindCompanyIdByUuid(Guid uuid)
            => companyRepository.FindAsync(uuid, CancellationToken.None)
                                .GetAwaiter()
                                .GetResult()
                               ?.Id
            ?? throw new NotFoundException($"Company ({uuid})");

        protected override Ticker BuildEntity()
            => TickerBuilder.GetInstance().ToBuild();
    }
}