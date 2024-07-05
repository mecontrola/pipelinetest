using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.DataStorage.Repositories
{
    public interface ICompanyRepository : IFilterAsyncRepository<Company, CompanyFilter>, IAsyncRepository<Company>
    {
        Task<Company> GetByB3CodeAsync(string b3Code, CancellationToken cancellationToken);
        Task<IList<Company>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class CompanyRepository(IDbAppContext context) : BaseAsyncRepository<Company>(context, context.Companies), ICompanyRepository
    {
        public async Task<Company> GetByB3CodeAsync(string b3Code, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.B3Code == b3Code)
                          .FirstOrDefaultAsync(cancellationToken);

        public async Task<IList<Company>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.Active)
                          .ToListAsync(cancellationToken);

        public async Task<IList<Company>> FindFilterAllAsync(CompanyFilter filter, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => (string.IsNullOrWhiteSpace(filter.Name) || (!string.IsNullOrWhiteSpace(filter.Name) && entity.Name.ToLower().Contains(filter.Name.ToLower())))
                                        && (!filter.Active.HasValue || (filter.Active.HasValue && entity.Active == filter.Active.Value)))
                          .ToListAsync(cancellationToken);
    }
}