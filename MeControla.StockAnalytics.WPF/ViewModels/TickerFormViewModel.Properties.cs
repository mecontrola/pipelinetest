using MeControla.StockAnalytics.Data.Dtos;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TickerFormViewModel
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

        private ObservableCollection<CompanyLiteDto> companyDataCollection = [];
        public ObservableCollection<CompanyLiteDto> CompanyDataCollection
        {
            get { return companyDataCollection; }
            set { SetProperty(ref companyDataCollection, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private string isinCode;
        public string ISINCode
        {
            get { return isinCode; }
            set { SetProperty(ref isinCode, value); }
        }

        private CompanyLiteDto company;
        public CompanyLiteDto Company
        {
            get { return company; }
            set { SetProperty(ref company, value); }
        }
    }
}