using MeControla.Core.WPF.Helpers;
using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;
using System.Windows;
using System.Windows.Input;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            ImageIconSource = AppIconHelper.IconLogo;
            Title = $"{LanguageHelper.Text.About} {AssemblyInfoHelper.AssemblyTitle}";
            ProductName = AssemblyInfoHelper.AssemblyProduct;
            Version = $"{LanguageHelper.Text.Version} {AssemblyInfoHelper.AssemblyVersion}";
            Copyright = AssemblyInfoHelper.AssemblyCopyright;
            Company = AssemblyInfoHelper.AssemblyCompany;
            Description = LanguageHelper.Text.Description;
        }

        public static ICommand CloseWindowCommand
            => new DelegateCommand(obj => (obj as Window)?.Close());
    }
}