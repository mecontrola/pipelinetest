using MeControla.Core.Data.Dtos;
using MeControla.Core.Data.Entities;
using MeControla.Core.Mappers;
using MeControla.Core.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services.Bases
{
    public interface IBaseEntityRetrieveService<TDto>
        where TDto : class, IDto
    {
        Task<TDto> GetAsync(Guid employeeUuid, CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    abstract class BaseEntityRetrieveService<TEntity, TDto>(IAsyncRepository<TEntity> repository,
                                                            IEntityToDtoMapper<TEntity, TDto> mapper)
        : IBaseEntityRetrieveService<TDto>
        where TEntity : class, IEntity
        where TDto : class, IDto
    {
        private readonly IAsyncRepository<TEntity> repository = repository;

        private readonly IEntityToDtoMapper<TEntity, TDto> mapper = mapper;

        public async Task<TDto> GetAsync(Guid employeeUuid, CancellationToken cancellationToken)
        {
            var entity = await repository.FindAsync(employeeUuid, cancellationToken);

            return mapper.ToMap(entity);
        }
    }
}