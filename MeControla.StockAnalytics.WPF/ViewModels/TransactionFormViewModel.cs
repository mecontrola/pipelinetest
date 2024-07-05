using MeControla.Core.Extensions;
using MeControla.Core.WPF.ViewModels;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.WPF.Business;
using MeControla.StockAnalytics.WPF.Events;
using MeControla.StockAnalytics.WPF.Extensions;
using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TransactionFormViewModel : BaseFormViewModel<TransactionFormViewModel, TransactionDto, TransactionInputDto, TransactionEvent>
    {
        private readonly CancellationTokenSource cancellationTokenSource;

        private readonly IBrokerBusiness brokerBusiness;
        private readonly ITickerBusiness tickerBusiness;
        private readonly IWalletBusiness walletBusiness;

        public TransactionFormViewModel(CancellationTokenSource cancellationTokenSource,
                                        ICommandManager commandManager,
                                        IBrokerBusiness brokerBusiness,
                                        ITickerBusiness tickerBusiness,
                                        ITransactionBusiness transactionBusiness,
                                        IWalletBusiness walletBusiness)
            : base(cancellationTokenSource, commandManager, transactionBusiness, TransactionEvent.Instance)
        {
            ImageIconSaveSource = AppIconHelper.IconSave16;
            ImageIconCancelSource = AppIconHelper.IconDelete16;

            this.cancellationTokenSource = cancellationTokenSource;

            this.brokerBusiness = brokerBusiness;
            this.tickerBusiness = tickerBusiness;
            this.walletBusiness = walletBusiness;

            AddFieldMap(dto => dto.WalletId, form => form.Wallet);
            AddFieldMap(dto => dto.BrokerId, form => form.Broker);
            AddFieldMap(dto => dto.TickerId, form => form.Ticker);
            AddFieldMap(dto => dto.Amount, form => form.Amount);
            AddFieldMap(dto => dto.Price, form => form.Price);
            AddFieldMap(dto => dto.Total, form => form.Total);

            BrokerEvent.Instance.OnListChangedEventHandler += AppEventManager_OnUpdateBrokerListEvent;
            TickerEvent.Instance.OnListChangedEventHandler += AppEventManager_OnUpdateTickerListEvent;
            WalletEvent.Instance.OnListChangedEventHandler += AppEventManager_OnUpdateWalletListEvent;
        }

        protected override async Task LoadExtraData(CancellationToken cancellationToken)
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

        protected override void FillForm(TransactionDto entity)
        {
            Wallet = WalletDataCollection.SelectOrDefault(entity?.Wallet);
            Broker = BrokerDataCollection.SelectOrDefault(entity?.Broker);
            Ticker = TickerDataCollection.SelectOrDefault(entity?.Ticker);
            Date = entity?.Date ?? DateTime.Now;
            Amount = entity?.Amount ?? 0;
            Price = entity?.Price ?? 0;
            Total = entity?.Total ?? 0;
            IsBuy = entity?.IsBuy ?? true;
        }

        protected override TransactionInputDto FillInputDto()
            => new()
            {
                WalletId = Wallet.GetValueOrDefault(),
                BrokerId = Broker.GetValueOrDefault(),
                TickerId = Ticker.GetValueOrDefault(),
                Date = Date,
                Amount = Amount,
                Price = Price,
                Total = Total,
                IsBuy = IsBuy
            };

        private async void AppEventManager_OnUpdateBrokerListEvent()
          => await LoadBrokerData(cancellationTokenSource.Token);

        private async void AppEventManager_OnUpdateTickerListEvent()
          => await LoadTickerData(cancellationTokenSource.Token);

        private async void AppEventManager_OnUpdateWalletListEvent()
          => await LoadWalletData(cancellationTokenSource.Token);
    }
}