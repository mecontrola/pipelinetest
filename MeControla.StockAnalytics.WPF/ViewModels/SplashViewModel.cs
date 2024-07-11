using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class SplashViewModel : BaseViewModel
    {
        public SplashViewModel()
        {
            ImageLogo = AppIconHelper.IconLogo;
            ImageIllustration = AppIconHelper.IconIllustration;
        }
    }
}