using MeControla.Core.WPF.Extensions;
using MeControla.Core.WPF.ViewModels;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.WPF.Business;
using MeControla.StockAnalytics.WPF.Events;
using MeControla.StockAnalytics.WPF.Helpers;
using MeControla.StockAnalytics.WPF.Windows;
using Microsoft.DotNetCore.Hosting.WPF;
using System;
using System.Threading;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TickerViewModel : BaseListViewModel<TickerFormWindow, TickerDto, TickerFilterInputDto, TickerEvent>
    {
        public TickerViewModel(IServiceProvider serviceProvider,
                               CancellationTokenSource cancellationTokenSource,
                               ICommandManager commandManager,
                               ITickerBusiness tickkerBusiness)
            : base(serviceProvider, cancellationTokenSource, commandManager, tickkerBusiness, TickerEvent.Instance)
        {
            ImageIconAddSource = AppIconHelper.IconAdd16;
            ImageIconUpdateSource = AppIconHelper.IconUpdate16;
            ImageIconActiveSource = AppIconHelper.IconActive16;
            ImageIconFilterSource = AppIconHelper.IconFilter16;
        }

        protected override TickerFilterInputDto FillFilterInputDto()
            => new()
            {
                Name = FilterName,
                Active = FilterActive.ToBoolNullable()
            };
    }
}