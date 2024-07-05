using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class WalletFormViewModel
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

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
    }
}