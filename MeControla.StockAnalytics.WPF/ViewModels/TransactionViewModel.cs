using MeControla.Core.Extensions;
using MeControla.Core.WPF.ViewModels;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.WPF.Business;
using MeControla.StockAnalytics.WPF.Events;
using MeControla.StockAnalytics.WPF.Extensions;
using MeControla.StockAnalytics.WPF.Helpers;
using MeControla.StockAnalytics.WPF.Windows;
using Microsoft.DotNetCore.Hosting.WPF;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TransactionViewModel : BaseListViewModel<TransactionFormWindow, TransactionDto, TransactionFilterInputDto, TransactionEvent>
    {
        private readonly CancellationTokenSource cancellationTokenSource;

        private readonly IBrokerBusiness brokerBusiness;
        private readonly ITickerBusiness tickerBusiness;
        private readonly IWalletBusiness walletBusiness;

        public TransactionViewModel(IServiceProvider serviceProvider,
                                    CancellationTokenSource cancellationTokenSource,
                                    ICommandManager commandManager,
                                    IBrokerBusiness brokerBusiness,
                                    ITickerBusiness tickerBusiness,
                                    ITransactionBusiness transactionBusiness,
                                    IWalletBusiness walletBusiness)
            : base(serviceProvider, cancellationTokenSource, commandManager, transactionBusiness, TransactionEvent.Instance)
        {
            ImageIconAddSource = AppIconHelper.IconAdd16;
            ImageIconUpdateSource = AppIconHelper.IconUpdate16;
            ImageIconActiveSource = AppIconHelper.IconActive16;
            ImageIconFilterSource = AppIconHelper.IconFilter16;

            this.cancellationTokenSource = cancellationTokenSource;

            this.brokerBusiness = brokerBusiness;
            this.tickerBusiness = tickerBusiness;
            this.walletBusiness = walletBusiness;

            _ = LoadFilterData(cancellationTokenSource.Token);
        }

        private async Task LoadFilterData(CancellationToken cancellationToken)
        {
            await LoadBrokerData(cancellationToken);
            await LoadTickerData(cancellationToken);
            await LoadWalletData(cancellationToken);
        }

        private async Task LoadBrokerData(CancellationToken cancellationToken)
        {
            var list = await brokerBusiness.GetAllActiveAsync(cancellationToken);

            BrokerDataCollection.AddList(list);
        }

        private async Task LoadTickerData(CancellationToken cancellationToken)
        {
            var list = await tickerBusiness.GetAllActiveAsync(cancellationToken);

            TickerDataCollection.AddList(list);
        }

        private async Task LoadWalletData(CancellationToken cancellationToken)
        {
            var list = await walletBusiness.GetAllActiveAsync(cancellationToken);

            WalletDataCollection.AddList(list);
        }

        protected override TransactionFilterInputDto FillFilterInputDto()
            => new()
            {
                BrokerId = FilterBroker.GetValueOrDefault(),
                TickerId = FilterTicker.GetValueOrDefault(),
                WalletId = FilterWallet.GetValueOrDefault(),
            };

        private async void AppEventManager_OnUpdateBrokerListEvent()
          => await LoadBrokerData(cancellationTokenSource.Token);

        private async void AppEventManager_OnUpdateTickerListEvent()
          => await LoadTickerData(cancellationTokenSource.Token);

        private async void AppEventManager_OnUpdateWalletListEvent()
          => await LoadWalletData(cancellationTokenSource.Token);
    }
}