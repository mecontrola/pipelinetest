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
    public partial class CompanyFormViewModel : BaseFormViewModel<CompanyFormViewModel, CompanyDto, CompanyInputDto, CompanyEvent>
    {
        public CompanyFormViewModel(CancellationTokenSource cancellationTokenSource,
                                    ICommandManager commandManager,
                                    ICompanyBusiness companyBusiness)
            : base(cancellationTokenSource, commandManager, companyBusiness, CompanyEvent.Instance)
        {
            ImageIconSaveSource = AppIconHelper.IconSave16;
            ImageIconCancelSource = AppIconHelper.IconDelete16;

            AddFieldMap(dto => dto.Name, form => form.Name);
        }

        protected override void FillForm(CompanyDto entity)
        {
            Name = entity?.Name ?? string.Empty;
            B3Code = entity?.B3Code;
            Document = entity?.Document ?? string.Empty;
        }

        protected override CompanyInputDto FillInputDto()
            => new()
            {
                Name = Name,
                B3Code = B3Code,
                Document = Document
            };
    }
}