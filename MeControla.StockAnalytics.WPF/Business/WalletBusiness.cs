using MeControla.Core.WPF.Business;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.IWalletBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface IWalletBusiness : IBaseFormViewModelBusiness<WalletDto, WalletInputDto>, IBaseListViewModelBusiness<WalletDto, WalletFilterInputDto>
    {
        Task<IList<WalletLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken);
        Task<IList<WalletLiteDto>> GetAllActiveWithTickersAsync(CancellationToken cancellationToken);
    }

    public sealed class WalletBusiness(CoreBusiness business) : IWalletBusiness
    {
        public async Task<IList<WalletDto>> GetFilterAllAsync(WalletFilterInputDto filter, CancellationToken cancellationToken)
            => await business.RetrieveFilterListAsync(filter, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await business.SwitchAtiveInactiveAsync(id, cancellationToken);

        public async Task<WalletDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await business.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, WalletInputDto input, CancellationToken cancellationToken)
            => await business.SaveAsync(id, input, cancellationToken);

        public async Task<IList<WalletLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await business.GetAllActiveAsync(cancellationToken);

        public async Task<IList<WalletLiteDto>> GetAllActiveWithTickersAsync(CancellationToken cancellationToken)
            => await business.GetAllActiveWithTickersAsync(cancellationToken);
    }
}