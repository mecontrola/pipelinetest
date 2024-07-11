using MeControla.Core.WPF.Tools;
using MeControla.StockAnalytics.WPF.Datas.Enums;
using MeControla.StockAnalytics.WPF.Windows;
using Microsoft.DotNetCore.Hosting;
using Microsoft.DotNetCore.Hosting.WPF;
using Microsoft.DotNetCore.WPF;
using System;
using System.Windows;
using System.Windows.Input;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly IUIManager uiManager;

        private readonly ILanguage<Languages> language;

        private readonly IServiceProvider serviceProvider;

        public MainViewModel(IUIManager uiManager, ILanguage<Languages> language, IServiceProvider serviceProvider)
        {
            this.uiManager = uiManager;
            this.language = language;
            this.serviceProvider = serviceProvider;

            ChangeCurrentViewModel(MenuItemCommands.Home);
        }

        public IUIManager UIManager { get => uiManager; }

        public ICommand UpdateViewCommand => new DelegateCommand<MenuItemCommands>(ChangeCurrentViewModel);

        private void ChangeCurrentViewModel(MenuItemCommands option)
        {
            switch (option)
            {
                case MenuItemCommands.About:
                    ManagerWindow.OpenFormWindow<AboutWindow>(serviceProvider);
                    return;
                case MenuItemCommands.LanguageEnUS:
                    language.ChangeTo(Languages.enUS);
                    return;
                case MenuItemCommands.LanguagePtBr:
                    language.ChangeTo(Languages.ptBR);
                    return;
                case MenuItemCommands.Exit:
                    Application.Current.Shutdown();
                    return;
            }

            CurrentViewModel = option switch
            {
                MenuItemCommands.Broker => serviceProvider.GetServiceInstance<BrokerViewModel>(),
                MenuItemCommands.Company => serviceProvider.GetServiceInstance<CompanyViewModel>(),
                MenuItemCommands.Register => serviceProvider.GetServiceInstance<RegisterViewModel>(),
                MenuItemCommands.Ticker => serviceProvider.GetServiceInstance<TickerViewModel>(),
                MenuItemCommands.Transaction => serviceProvider.GetServiceInstance<TransactionViewModel>(),
                MenuItemCommands.Synchronize => serviceProvider.GetServiceInstance<SynchronizeViewModel>(),
                MenuItemCommands.Wallet => serviceProvider.GetServiceInstance<WalletViewModel>(),
                _ => serviceProvider.GetServiceInstance<HomeViewModel>(),
            };
        }
    }
}