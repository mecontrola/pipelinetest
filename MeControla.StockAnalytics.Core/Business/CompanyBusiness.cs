using MeControla.StockAnalytics.Core.Services;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Business
{
    public interface ICompanyBusiness
    {
        Task<IList<CompanyDto>> RetrieveFilterListAsync(CompanyFilterInputDto filterInputDto, CancellationToken cancellationToken);
        Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken);
        Task<CompanyDto> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> SaveAsync(Guid? id, CompanyInputDto input, CancellationToken cancellationToken);
        Task<IList<CompanyLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class CompanyBusiness(ICompanyRetrieveFilterListService companyRetrieveFilterListService,
                                        ICompanyRetrieveService companyRetrieveService,
                                        ICompanyRetrieveListActiveService companyRetrieveListActiveService,
                                        ICompanySaveService companySaveService,
                                        ICompanySwitchAtiveInactiveService companySwitchAtiveInactiveService)
        : ICompanyBusiness
    {
        public async Task<IList<CompanyDto>> RetrieveFilterListAsync(CompanyFilterInputDto filterInputDto, CancellationToken cancellationToken)
            => await companyRetrieveFilterListService.GetFilterListAsync(filterInputDto, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await companySwitchAtiveInactiveService.SwitchStatusAsync(id, cancellationToken);

        public async Task<CompanyDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await companyRetrieveService.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, CompanyInputDto input, CancellationToken cancellationToken)
            => await companySaveService.SaveAsync(id, input, cancellationToken);

        public async Task<IList<CompanyLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await companyRetrieveListActiveService.GetListAsync(cancellationToken);
    }
}