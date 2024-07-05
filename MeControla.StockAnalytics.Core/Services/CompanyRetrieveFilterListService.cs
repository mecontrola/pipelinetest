using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ICompanyRetrieveFilterListService : IBaseEntityRetrieveFilterListService<CompanyDto, CompanyFilterInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyRetrieveFilterListService(ICompanyRepository companyRepository,
                                                  ICompanyInputDtoToFilterEntityMapper companyInputDtoToFilterEntityMapper,
                                                  ICompanyEntityToDtoMapper companyEntityToDtoMapper)
        : BaseEntityRetrieveFilterListService<Company, CompanyDto, CompanyFilter, CompanyFilterInputDto>(companyRepository,
                                                                                                         companyInputDtoToFilterEntityMapper,
                                                                                                         companyEntityToDtoMapper)
        , ICompanyRetrieveFilterListService
    { }
}