using MeControla.Core.Data.Dtos;
using MeControla.Core.Extensions;
using MeControla.Core.WPF.ViewModels;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.WPF.Business;
using MeControla.StockAnalytics.WPF.Events;
using MeControla.StockAnalytics.WPF.Extensions;
using MeControla.StockAnalytics.WPF.Helpers;
using Microsoft.DotNetCore.Hosting.WPF;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TickerFormViewModel : BaseFormViewModel<TickerFormViewModel, TickerDto, TickerInputDto, TickerEvent>
    {
        private readonly ICompanyBusiness companyBusiness;

        public TickerFormViewModel(CancellationTokenSource cancellationTokenSource,
                                   ICommandManager commandManager,
                                   ICompanyBusiness companyBusiness,
                                   ITickerBusiness tickerBusiness)
            : base(cancellationTokenSource, commandManager, tickerBusiness, TickerEvent.Instance)
        {
            ImageIconSaveSource = AppIconHelper.IconSave16;
            ImageIconCancelSource = AppIconHelper.IconDelete16;

            this.companyBusiness = companyBusiness;

            AddFieldMap(dto => dto.Name, form => form.Name);
            AddFieldMap(dto => dto.ISINCode, form => form.ISINCode);
            AddFieldMap(dto => dto.CompanyId, form => form.Company);
        }

        protected override async Task LoadExtraData(CancellationToken cancellationToken)
        {
            var employeeList = await companyBusiness.GetAllActiveAsync(cancellationToken);

            CompanyDataCollection.AddList(employeeList);
        }

        protected override void FillForm(TickerDto entity)
        {
            Name = entity.GetValueOrDefault(itm => itm.Name);
            ISINCode = entity.GetValueOrDefault(itm => itm.ISINCode);
            Company = CompanyDataCollection.SelectOrDefault(entity?.Company);
        }

        protected override TickerInputDto FillInputDto()
            => new()
            {
                Name = Name,
                ISINCode = ISINCode,
                CompanyId = Company.GetValueOrDefault()
            };
    }
}