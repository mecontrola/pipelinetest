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
 public partial class CompanyViewModel : BaseListViewModel<CompanyFormWindow, CompanyDto, CompanyFilterInputDto, CompanyEvent>
    {
        public CompanyViewModel(IServiceProvider serviceProvider,
                                CancellationTokenSource cancellationTokenSource,
                                ICommandManager commandManager,
                                ICompanyBusiness companyBusiness)
            : base(serviceProvider, cancellationTokenSource, commandManager, companyBusiness, CompanyEvent.Instance)
        {
            ImageIconAddSource = AppIconHelper.IconAdd16;
            ImageIconUpdateSource = AppIconHelper.IconUpdate16;
            ImageIconActiveSource = AppIconHelper.IconActive16;
            ImageIconFilterSource = AppIconHelper.IconFilter16;
        }

        protected override CompanyFilterInputDto FillFilterInputDto()
            => new()
            {
                Name = FilterName,
                Active = FilterActive.ToBoolNullable()
            };
    }
}