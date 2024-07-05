using MeControla.StockAnalytics.Core.Services;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Business
{
    public interface IBrokerBusiness
    {
        Task<IList<BrokerDto>> RetrieveFilterListAsync(BrokerFilterInputDto filterInputDto, CancellationToken cancellationToken);
        Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken);
        Task<BrokerDto> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> SaveAsync(Guid? id, BrokerInputDto input, CancellationToken cancellationToken);
        Task<IList<BrokerLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class BrokerBusiness(IBrokerRetrieveFilterListService brokerRetrieveFilterListService,
                                       IBrokerRetrieveService brokerRetrieveService,
                                       IBrokerRetrieveListActiveService brokerRetrieveListActiveService,
                                       IBrokerSaveService brokerSaveService,
                                       IBrokerSwitchAtiveInactiveService brokerSwitchAtiveInactiveService)
        : IBrokerBusiness
    {
        public async Task<IList<BrokerDto>> RetrieveFilterListAsync(BrokerFilterInputDto filterInputDto, CancellationToken cancellationToken)
            => await brokerRetrieveFilterListService.GetFilterListAsync(filterInputDto, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await brokerSwitchAtiveInactiveService.SwitchStatusAsync(id, cancellationToken);

        public async Task<BrokerDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await brokerRetrieveService.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, BrokerInputDto input, CancellationToken cancellationToken)
            => await brokerSaveService.SaveAsync(id, input, cancellationToken);

        public async Task<IList<BrokerLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await brokerRetrieveListActiveService.GetListAsync(cancellationToken);
    }
}