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
    public partial class RegisterFormViewModel : BaseFormViewModel<RegisterFormViewModel, RegisterDto, RegisterInputDto, RegisterEvent>
    {
        public RegisterFormViewModel(CancellationTokenSource cancellationTokenSource,
                                     ICommandManager commandManager,
                                     IRegisterBusiness registerBusiness)
            : base(cancellationTokenSource, commandManager, registerBusiness, RegisterEvent.Instance)
        {
            ImageIconSaveSource = AppIconHelper.IconSave16;
            ImageIconCancelSource = AppIconHelper.IconDelete16;

            AddFieldMap(dto => dto.Name, form => form.Name);
        }

        protected override void FillForm(RegisterDto entity)
        {
            Name = entity?.Name ?? string.Empty;
            Website = entity?.Website ?? string.Empty;
        }

        protected override RegisterInputDto FillInputDto()
            => new()
            {
                Name = Name,
                Website = Website
            };
    }
}