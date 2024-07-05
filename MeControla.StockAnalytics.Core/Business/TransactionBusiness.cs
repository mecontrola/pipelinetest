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
    public interface ITransactionBusiness
    {
        Task<IList<TransactionDto>> RetrieveFilterListAsync(TransactionFilterInputDto filterInputDto, CancellationToken cancellationToken);
        Task<TransactionDto> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> SaveAsync(Guid? id, TransactionInputDto input, CancellationToken cancellationToken);
    }

    public sealed class TransactionBusiness(ITransactionRetrieveFilterListService transactionRetrieveFilterListService,
                                            ITransactionRetrieveService transactionRetrieveService,
                                            ITransactionSaveService transactionSaveService)
        : ITransactionBusiness
    {
        public async Task<IList<TransactionDto>> RetrieveFilterListAsync(TransactionFilterInputDto filterInputDto, CancellationToken cancellationToken)
            => await transactionRetrieveFilterListService.GetFilterListAsync(filterInputDto, cancellationToken);

        public async Task<TransactionDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await transactionRetrieveService.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, TransactionInputDto input, CancellationToken cancellationToken)
            => await transactionSaveService.SaveAsync(id, input, cancellationToken);
    }
}