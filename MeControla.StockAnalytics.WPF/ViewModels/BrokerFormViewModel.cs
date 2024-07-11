using MeControla.Core.WPF.ViewModels;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.WPF.Business;
using MeControla.StockAnalytics.WPF.Events;
using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;
using System.Threading;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class BrokerFormViewModel : BaseFormViewModel<BrokerFormViewModel, BrokerDto, BrokerInputDto, BrokerEvent>
    {
        public BrokerFormViewModel(CancellationTokenSource cancellationTokenSource,
                                   ICommandManager commandManager,
                                   IBrokerBusiness brokerBusiness)
            : base(cancellationTokenSource, commandManager, brokerBusiness, BrokerEvent.Instance)
        {
            ImageIconSaveSource = AppIconHelper.IconSave16;
            ImageIconCancelSource = AppIconHelper.IconDelete16;

            AddFieldMap(dto => dto.Name, form => form.Name);
        }

        protected override void FillForm(BrokerDto entity)
            => Name = entity?.Name ?? string.Empty;

        protected override BrokerInputDto FillInputDto()
            => new()
            {
                Name = Name,
            };
    }
}