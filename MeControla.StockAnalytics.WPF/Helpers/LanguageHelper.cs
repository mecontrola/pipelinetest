using System.Windows;

namespace MeControla.StockAnalytics.WPF.Helpers
{
    public class LanguageHelper
    {
        public class Text
        {
            private const string TEXT_ABOUT = "Text-About";
            public static string About { get; } = GetResourceValue(TEXT_ABOUT);

            private const string TEXT_DESCRIPTION = "Text-Description";
            public static string Description { get; } = GetResourceValue(TEXT_DESCRIPTION);

            private const string TEXT_NO = "Text-No";
            public static string No { get; } = GetResourceValue(TEXT_NO);

            private const string TEXT_READY = "Text-Ready";
            public static string Ready { get; } = GetResourceValue(TEXT_READY);

            private const string TEXT_RUNNING = "Text-Running";
            public static string Running { get; } = GetResourceValue(TEXT_RUNNING);
            
            private const string TEXT_VERSION = "Text-Version";
            public static string Version { get; } = GetResourceValue(TEXT_VERSION);

            private const string TEXT_YES = "Text-Yes";
            public static string Yes { get; } = GetResourceValue(TEXT_YES);
        }

        private static string GetResourceValue(string key)
            => Application.Current.Resources[key].ToString();
    }
}