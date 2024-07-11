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
    public partial class BrokerViewModel : BaseListViewModel<BrokerFormWindow, BrokerDto, BrokerFilterInputDto, BrokerEvent>
    {
        public BrokerViewModel(IServiceProvider serviceProvider,
                               CancellationTokenSource cancellationTokenSource,
                               ICommandManager commandManager,
                               IBrokerBusiness brokerBusiness)
            : base(serviceProvider, cancellationTokenSource, commandManager, brokerBusiness, BrokerEvent.Instance)
        {
            ImageIconAddSource = AppIconHelper.IconAdd16;
            ImageIconUpdateSource = AppIconHelper.IconUpdate16;
            ImageIconActiveSource = AppIconHelper.IconActive16;
            ImageIconFilterSource = AppIconHelper.IconFilter16;
        }

        protected override BrokerFilterInputDto FillFilterInputDto()
            => new()
            {
                Name = FilterName,
                Active = FilterActive.ToBoolNullable()
            };
    }
}