using MeControla.Core.WPF.Business;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.ITransactionBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface ITransactionBusiness : IBaseFormViewModelBusiness<TransactionDto, TransactionInputDto>, IBaseListViewModelBusiness<TransactionDto, TransactionFilterInputDto>
    { }

    public sealed class TransactionBusiness(CoreBusiness business) : ITransactionBusiness
    {
        public async Task<IList<TransactionDto>> GetFilterAllAsync(TransactionFilterInputDto filter, CancellationToken cancellationToken)
            => await business.RetrieveFilterListAsync(filter, cancellationToken);

        public Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public async Task<TransactionDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await business.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, TransactionInputDto input, CancellationToken cancellationToken)
            => await business.SaveAsync(id, input, cancellationToken);
    }
}