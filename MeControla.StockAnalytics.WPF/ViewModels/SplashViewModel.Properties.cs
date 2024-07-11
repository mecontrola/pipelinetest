using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class SplashViewModel
    {
        private ImageSource imageLogo;
        public ImageSource ImageLogo
        {
            get { return imageLogo; }
            set { SetProperty(ref imageLogo, value); }
        }

        private ImageSource imageIllustration;
        public ImageSource ImageIllustration
        {
            get { return imageIllustration; }
            set { SetProperty(ref imageIllustration, value); }
        }
    }
}