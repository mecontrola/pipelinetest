using MeControla.StockAnalytics.Data.Dtos;
using System.Collections.ObjectModel;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class HomeViewModel
    {
        private ObservableCollection<WalletLiteDto> walletDataCollection = [];

        public ObservableCollection<WalletLiteDto> WalletDataCollection
        {
            get { return walletDataCollection; }
            set { SetProperty(ref walletDataCollection, value); }
        }

        private WalletLiteDto walletSelected;

        public WalletLiteDto WalletSelected
        {
            get { return walletSelected; }
            set { SetProperty(ref walletSelected, value); }
        }
    }
}