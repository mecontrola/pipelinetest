using MeControla.StockAnalytics.Data.Dtos;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TransactionViewModel
    {
        private ImageSource imageIconAddSource;
        public ImageSource ImageIconAddSource
        {
            get { return imageIconAddSource; }
            set { SetProperty(ref imageIconAddSource, value); }
        }

        private ImageSource imageIconUpdateSource;
        public ImageSource ImageIconUpdateSource
        {
            get { return imageIconUpdateSource; }
            set { SetProperty(ref imageIconUpdateSource, value); }
        }

        private ImageSource imageIconActiveSource;
        public ImageSource ImageIconActiveSource
        {
            get { return imageIconActiveSource; }
            set { SetProperty(ref imageIconActiveSource, value); }
        }

        private ImageSource imageIconFilterSource;
        public ImageSource ImageIconFilterSource
        {
            get { return imageIconFilterSource; }
            set { SetProperty(ref imageIconFilterSource, value); }
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

        private BrokerLiteDto filterBroker;
        public BrokerLiteDto FilterBroker
        {
            get { return filterBroker; }
            set { SetProperty(ref filterBroker, value); }
        }

        private TickerLiteDto filterTicker;
        public TickerLiteDto FilterTicker
        {
            get { return filterTicker; }
            set { SetProperty(ref filterTicker, value); }
        }

        private WalletLiteDto filterWallet;
        public WalletLiteDto FilterWallet
        {
            get { return filterWallet; }
            set { SetProperty(ref filterWallet, value); }
        }

        private DateTime? filterDate;
        public DateTime? FilterDate
        {
            get { return filterDate; }
            set { SetProperty(ref filterDate, value); }
        }
    }
}