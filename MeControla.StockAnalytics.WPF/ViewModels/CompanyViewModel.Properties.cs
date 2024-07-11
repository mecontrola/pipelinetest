using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class CompanyViewModel
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

        private string filterName;
        public string FilterName
        {
            get { return filterName; }
            set { SetProperty(ref filterName, value); }
        }

        private string filterActive;
        public string FilterActive
        {
            get { return filterActive; }
            set { SetProperty(ref filterActive, value); }
        }
    }
}