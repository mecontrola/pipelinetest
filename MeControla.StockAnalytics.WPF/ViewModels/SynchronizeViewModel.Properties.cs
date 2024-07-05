using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class SynchronizeViewModel
    {
        private ImageSource imageIconPlaySource;
        public ImageSource ImageIconPlaySource
        {
            get { return imageIconPlaySource; }
            set { SetProperty(ref imageIconPlaySource, value); }
        }

        private bool barEnabled = true;
        public bool BarEnabled
        {
            get { return barEnabled; }
            set { SetProperty(ref barEnabled, value); }
        }

        private bool formEnabled = true;
        public bool FormEnabled
        {
            get { return formEnabled; }
            set { SetProperty(ref formEnabled, value); }
        }
    }
}