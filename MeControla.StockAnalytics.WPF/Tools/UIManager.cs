using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;
using System;
using System.Windows;

namespace MeControla.StockAnalytics.WPF.Tools
{
    public sealed class UIManager : BaseViewModel, IUIManager
    {
        private string statusBarText;
        public string StatusBarText
        {
            get { return statusBarText; }
            set { SetProperty(ref statusBarText, value); }
        }

        private bool menuBarEnabled = true;
        public bool MenuBarEnabled
        {
            get { return menuBarEnabled; }
            set { SetProperty(ref menuBarEnabled, value); }
        }

        private Visibility progressBarVisibility = Visibility.Collapsed;
        public Visibility ProgressBarVisibility
        {
            get { return progressBarVisibility; }
            set { SetProperty(ref progressBarVisibility, value); }
        }

        public void SetEnabled(bool isEnabled)
        {
            MenuBarEnabled = isEnabled;
            ProgressBarVisibility = BoolConverters.ToVisibility(!isEnabled);
            StatusBarText = isEnabled
                          ? LanguageHelper.Text.Ready
                          : LanguageHelper.Text.Running;
        }
    }
}