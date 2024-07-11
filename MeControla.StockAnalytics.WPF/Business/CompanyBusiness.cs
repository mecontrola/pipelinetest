using MeControla.Core.WPF.Business;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.ICompanyBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface ICompanyBusiness : IBaseFormViewModelBusiness<CompanyDto, CompanyInputDto>, IBaseListViewModelBusiness<CompanyDto, CompanyFilterInputDto>
    {
        Task<IList<CompanyLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class CompanyBusiness(CoreBusiness business) : ICompanyBusiness
    {
        public async Task<IList<CompanyDto>> GetFilterAllAsync(CompanyFilterInputDto filter, CancellationToken cancellationToken)
            => await business.RetrieveFilterListAsync(filter, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await business.SwitchAtiveInactiveAsync(id, cancellationToken);

        public async Task<CompanyDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await business.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, CompanyInputDto input, CancellationToken cancellationToken)
            => await business.SaveAsync(id, input, cancellationToken);

        public async Task<IList<CompanyLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await business.GetAllActiveAsync(cancellationToken);
    }
}