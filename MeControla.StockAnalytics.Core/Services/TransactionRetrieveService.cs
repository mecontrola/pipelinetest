using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITransactionRetrieveService : IBaseEntityRetrieveService<TransactionDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TransactionRetrieveService(ITransactionRepository transactionRepository,
                                            ITransactionEntityToDtoMapper transactionEntityToDtoMapper)
        : BaseEntityRetrieveService<Transaction, TransactionDto>(transactionRepository, transactionEntityToDtoMapper), ITransactionRetrieveService
    { }
}