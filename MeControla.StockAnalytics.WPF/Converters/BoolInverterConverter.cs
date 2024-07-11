using System;
using System.Globalization;
using System.Windows.Data;

namespace MeControla.StockAnalytics.WPF.Converters
{
    public class BoolInverterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value is bool booleanValue
             ? !booleanValue
             : value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => value is bool booleanValue
             ? !booleanValue
             : value;
    }
}