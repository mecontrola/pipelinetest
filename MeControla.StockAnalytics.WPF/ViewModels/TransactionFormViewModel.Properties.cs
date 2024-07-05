using MeControla.StockAnalytics.Data.Dtos;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TransactionFormViewModel
    {
        private ImageSource imageIconCancelSource;
        public ImageSource ImageIconCancelSource
        {
            get { return imageIconCancelSource; }
            set { SetProperty(ref imageIconCancelSource, value); }
        }

        private ImageSource imageIconSaveSource;
        public ImageSource ImageIconSaveSource
        {
            get { return imageIconSaveSource; }
            set { SetProperty(ref imageIconSaveSource, value); }
        }

        private ObservableCollection<BrokerLiteDto> brokerDataCollection = [];
        public ObservableCollection<BrokerLiteDto> BrokerDataCollection
        {
            get { return brokerDataCollection; }
            set { SetProperty(ref brokerDataCollection, value); }
        }

        private ObservableCollection<TickerLiteDto> tickerDataCollection = [];
        public ObservableCollection<TickerLiteDto> TickerDataCollection
        {
            get { return tickerDataCollection; }
            set { SetProperty(ref tickerDataCollection, value); }
        }

        private ObservableCollection<WalletLiteDto> walletDataCollection = [];
        public ObservableCollection<WalletLiteDto> WalletDataCollection
        {
            get { return walletDataCollection; }
            set { SetProperty(ref walletDataCollection, value); }
        }

        private BrokerLiteDto broker;
        public BrokerLiteDto Broker
        {
            get { return broker; }
            set { SetProperty(ref broker, value); }
        }

        private TickerLiteDto ticker;
        public TickerLiteDto Ticker
        {
            get { return ticker; }
            set { SetProperty(ref ticker, value); }
        }

        private WalletLiteDto wallet;
        public WalletLiteDto Wallet
        {
            get { return wallet; }
            set { SetProperty(ref wallet, value); }
        }

        private DateTime date = DateTime.Now;
        public DateTime Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }

        private bool isBuy = true;
        public bool IsBuy
        {
            get { return isBuy; }
            set { SetProperty(ref isBuy, value); }
        }

        private long amount;
        public long Amount
        {
            get { return amount; }
            set
            {
                SetProperty(ref amount, value);

                CalculateTotal();
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                SetProperty(ref price, value);

                CalculateTotal();
            }
        }

        private void CalculateTotal()
            => Total = Amount * Price;

        private decimal total;
        public decimal Total
        {
            get { return total; }
            set { SetProperty(ref total, value); }
        }
    }
}