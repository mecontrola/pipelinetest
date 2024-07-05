using MeControla.StockAnalytics.WPF.Business;
using MeControla.StockAnalytics.WPF.Events;
using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;
using System.Threading;
using System.Windows.Input;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class SynchronizeViewModel : BaseViewModel
    {
        private readonly CancellationTokenSource cancellationTokenSource;

        private readonly ICommandManager commandManager;

        private readonly ISynchronizeBusiness synchronizeBusiness;

        public SynchronizeViewModel(CancellationTokenSource cancellationTokenSource,
                                    ICommandManager commandManager,
                                    ISynchronizeBusiness synchronizeBusiness)
        {
            ImageIconPlaySource = AppIconHelper.IconPlay16;

            this.cancellationTokenSource = cancellationTokenSource;
            this.commandManager = commandManager;
            this.synchronizeBusiness = synchronizeBusiness;
        }

        public ICommand RunCommand => new DelegateCommand(_ =>
        {
            commandManager.RunAsync(async () =>
            {
                await synchronizeBusiness.RunAllAsync(cancellationTokenSource.Token);

                CompanyEvent.Instance.OnListChanged();
                TickerEvent.Instance.OnListChanged();
            },
            () => SetFormEnabled(false),
            () => SetFormEnabled(true));
        });

        private void SetFormEnabled(bool isEnabled)
        {
            BarEnabled = isEnabled;
            FormEnabled = isEnabled;
        }
    }
}