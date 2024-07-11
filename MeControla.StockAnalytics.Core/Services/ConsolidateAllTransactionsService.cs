using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Enums;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IConsolidateAllTransactionsService
    {
        Task OrganizeAsync(long tickerId, long walletId, CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class ConsolidateAllTransactionsService(IConsolidatedRepository consolidatedRepository,
                                                   ITransactionRepository transactionRepository)
        : IConsolidateAllTransactionsService
    {
        public async Task OrganizeAsync(long tickerId, long walletId, CancellationToken cancellationToken)
        {
            var transactions = await transactionRepository.FindAllByTickerIdAndWalletIdAsync(tickerId, walletId, cancellationToken);
            var consolidated = await consolidatedRepository.FindByTickerIdAndWalletIdAsync(tickerId, walletId, cancellationToken)
                            ?? CreateEntity(tickerId, walletId);

            var amount = 0L;
            var price = 0M;
            var total = 0M;

            foreach (var transaction in transactions)
            {
                if (transaction.Action == TransactionAction.Purchase)
                {
                    amount += transaction.Amount;
                    total += transaction.Total;
                    price = total / amount;
                }
                else
                {
                    amount -= transaction.Amount;
                    total = price * amount;
                }
            }

            consolidated.Amount = amount;
            consolidated.Price = price;
            consolidated.Total = total;

            if (consolidated.Id == 0)
                await consolidatedRepository.CreateAsync(consolidated, cancellationToken);
            else
                await consolidatedRepository.UpdateAsync(consolidated, cancellationToken);
        }

        private static Consolidated CreateEntity(long tickerId, long walletId)
            => ConsolidatedBuilder.GetInstance()
                                  .SetTickerId(tickerId)
                                  .SetWalletId(walletId)
                                  .ToBuild();
    }
}