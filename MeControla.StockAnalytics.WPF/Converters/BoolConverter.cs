using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MeControla.StockAnalytics.WPF.Converters
{
    [ValueConversion(typeof(bool), typeof(string))]
    public class BoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value == null
             ? string.Empty
             : GetValueText(value);

        private static string GetValueText(object value)
            => ((bool)value)
             ? Application.Current.Resources["Text-Yes"].ToString()
             : Application.Current.Resources["Text-No"].ToString();

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => value.ToString() == Application.Current.Resources["Text-Yes"].ToString();
    }
}