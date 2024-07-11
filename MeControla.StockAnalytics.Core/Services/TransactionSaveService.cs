using MeControla.Core.Data.Entities;
using MeControla.Core.Exceptions;
using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Core.Validators;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Enums;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITransactionSaveService : IBaseEntitySaveService<TransactionInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TransactionSaveService(IBrokerRepository brokerRepository,
                                        ITickerRepository tickerRepository,
                                        ITransactionRepository transactionRepository,
                                        IWalletRepository walletRepository,
                                        ITransactionInputDtoValidator transactionInputDtoValidator,
                                        IConsolidateAllTransactionsService consolidateAllTransactionsService)
        : BaseEntitySaveService<Transaction, TransactionInputDto>(transactionRepository, transactionInputDtoValidator), ITransactionSaveService
    {
        protected override void FillEntity(Transaction entity, TransactionInputDto input)
        {
            entity.Amount = input.Amount;
            entity.Price = input.Price;
            entity.Total = input.Total;
            entity.Date = input.Date;
            entity.BrokerId = FindBrokerIdByUuid(input.BrokerId);
            entity.TickerId = FindTickerIdByUuid(input.TickerId);
            entity.WalletId = FindWalletIdByUuid(input.WalletId);
            entity.Action = ConvertBoolToEnum(input.IsBuy);
        }

        private static TransactionAction ConvertBoolToEnum(bool isBuy)
            => isBuy
             ? TransactionAction.Purchase
             : TransactionAction.Sale;

        private long FindBrokerIdByUuid(Guid uuid)
            => FindEntityIdByUuid(brokerRepository, uuid)
            ?? throw new NotFoundException($"Broker ({uuid})");

        private long FindTickerIdByUuid(Guid uuid)
            => FindEntityIdByUuid(tickerRepository, uuid)
            ?? throw new NotFoundException($"Ticker ({uuid})");

        private long FindWalletIdByUuid(Guid uuid)
            => FindEntityIdByUuid(walletRepository, uuid)
            ?? throw new NotFoundException($"Wallet ({uuid})");

        private static long? FindEntityIdByUuid<T>(IAsyncRepository<T> repository, Guid uuid)
            where T : class, IEntity
            => repository.FindAsync(uuid, CancellationToken.None)
                         .GetAwaiter()
                         .GetResult()
                        ?.Id;

        protected override Transaction BuildEntity()
            => TransactionBuilder.GetInstance().ToBuild();

        protected override async Task RunBeforeSave(Transaction entity, CancellationToken cancellationToken)
            => await consolidateAllTransactionsService.OrganizeAsync(entity.TickerId, entity.WalletId, cancellationToken);
    }
}