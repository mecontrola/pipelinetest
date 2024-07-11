using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MeControla.StockAnalytics.WPF.Helpers
{
    public static class BoolSourceHelper
    {
        public static ObservableCollection<KeyValuePair<bool, string>> ItemSource()
            => [
                new KeyValuePair<bool, string>( false, LanguageHelper.Text.No ),
                new KeyValuePair<bool, string>( true, LanguageHelper.Text.Yes),
            ];
    }
}