using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ICompanyRetrieveListActiveService
    {
        Task<IList<CompanyLiteDto>> GetListAsync(CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyRetrieveListActiveService(ICompanyRepository companyRepository,
                                                  ICompanyLiteEntityToDtoMapper companyLiteEntityToDtoMapper)
        : ICompanyRetrieveListActiveService
    {
        public async Task<IList<CompanyLiteDto>> GetListAsync(CancellationToken cancellationToken)
        {
            var list = await companyRepository.GetAllActiveAsync(cancellationToken);

            return companyLiteEntityToDtoMapper.ToMapList(list);
        }
    }
}