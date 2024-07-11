using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class AboutViewModel
    {
        private ImageSource imageIconSource;
        public ImageSource ImageIconSource
        {
            get { return imageIconSource; }
            set { SetProperty(ref imageIconSource, value); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { SetProperty(ref productName, value); }
        }

        private string version;
        public string Version
        {
            get { return version; }
            set { SetProperty(ref version, value); }
        }

        private string copyright;
        public string Copyright
        {
            get { return copyright; }
            set { SetProperty(ref copyright, value); }
        }

        private string company;
        public string Company
        {
            get { return company; }
            set { SetProperty(ref company, value); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
    }
}