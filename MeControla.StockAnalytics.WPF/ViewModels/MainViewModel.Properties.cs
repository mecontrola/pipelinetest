using Microsoft.DotNetCore.Hosting.WPF;
using System.Windows;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class MainViewModel
    {
        private BaseViewModel currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }
    }
}