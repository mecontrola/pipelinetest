using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ICompanyRetrieveService : IBaseEntityRetrieveService<CompanyDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyRetrieveService(ICompanyRepository companyRepository,
                                        ICompanyEntityToDtoMapper companyEntityToDtoMapper)
        : BaseEntityRetrieveService<Company, CompanyDto>(companyRepository, companyEntityToDtoMapper), ICompanyRetrieveService
    { }
}