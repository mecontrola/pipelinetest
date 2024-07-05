using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITransactionRetrieveFilterListService : IBaseEntityRetrieveFilterListService<TransactionDto, TransactionFilterInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TransactionRetrieveFilterListService(ITransactionRepository transactionRepository,
                                                      ITransactionInputDtoToFilterEntityMapper transactionInputDtoToFilterEntityMapper,
                                                      ITransactionEntityToDtoMapper transactionEntityToDtoMapper)
        : BaseEntityRetrieveFilterListService<Transaction, TransactionDto, TransactionFilter, TransactionFilterInputDto>(transactionRepository,
                                                                                                                         transactionInputDtoToFilterEntityMapper,
                                                                                                                         transactionEntityToDtoMapper)
        , ITransactionRetrieveFilterListService
    { }
}