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
    public partial class WalletFormViewModel : BaseFormViewModel<WalletFormViewModel, WalletDto, WalletInputDto, WalletEvent>
    {
        public WalletFormViewModel(CancellationTokenSource cancellationTokenSource,
                                   ICommandManager commandManager,
                                   IWalletBusiness walletBusiness)
            : base(cancellationTokenSource, commandManager, walletBusiness, WalletEvent.Instance)
        {
            ImageIconSaveSource = AppIconHelper.IconSave16;
            ImageIconCancelSource = AppIconHelper.IconDelete16;

            AddFieldMap(dto => dto.Name, form => form.Name);
        }

        protected override void FillForm(WalletDto entity)
            => Name = entity?.Name ?? string.Empty;

        protected override WalletInputDto FillInputDto()
            => new()
            {
                Name = Name,
            };
    }
}