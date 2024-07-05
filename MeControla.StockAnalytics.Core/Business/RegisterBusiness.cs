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
    public interface IRegisterBusiness
    {
        Task<IList<RegisterDto>> RetrieveFilterListAsync(RegisterFilterInputDto filterInputDto, CancellationToken cancellationToken);
        Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken);
        Task<RegisterDto> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> SaveAsync(Guid? id, RegisterInputDto input, CancellationToken cancellationToken);
    }

    public sealed class RegisterBusiness(IRegisterRetrieveFilterListService registerRetrieveFilterListService,
                                         IRegisterRetrieveService registerRetrieveService,
                                         IRegisterSaveService registerSaveService,
                                         IRegisterSwitchAtiveInactiveService registerSwitchAtiveInactiveService)
        : IRegisterBusiness
    {
        public async Task<IList<RegisterDto>> RetrieveFilterListAsync(RegisterFilterInputDto filterInputDto, CancellationToken cancellationToken)
            => await registerRetrieveFilterListService.GetFilterListAsync(filterInputDto, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await registerSwitchAtiveInactiveService.SwitchStatusAsync(id, cancellationToken);

        public async Task<RegisterDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await registerRetrieveService.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, RegisterInputDto input, CancellationToken cancellationToken)
            => await registerSaveService.SaveAsync(id, input, cancellationToken);
    }    }