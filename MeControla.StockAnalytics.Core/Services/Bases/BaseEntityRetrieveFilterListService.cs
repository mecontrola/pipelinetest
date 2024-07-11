using MeControla.Core.Data.Dtos;
using MeControla.Core.Data.Entities;
using MeControla.Core.Mappers;
using MeControla.Core.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services.Bases
{
    public interface IBaseEntityRetrieveFilterListService<TDto, TFilterInputDto>
            where TDto : class, IDto
            where TFilterInputDto : class, IInputDto
    {
        Task<IList<TDto>> GetFilterListAsync(TFilterInputDto filter, CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    abstract class BaseEntityRetrieveFilterListService<TEntity, TDto, TFilterEntity, TFilterInputDto>(IFilterAsyncRepository<TEntity, TFilterEntity> repository,
                                                                                                      IInputDtoToFilterEntityMapper<TFilterInputDto, TFilterEntity> mapperFilter,
                                                                                                      IEntityToDtoMapper<TEntity, TDto> mapper) : IBaseEntityRetrieveFilterListService<TDto, TFilterInputDto>
        where TEntity : class, IEntity
        where TDto : class, IDto
        where TFilterEntity : class, IFilterEntity
        where TFilterInputDto : class, IInputDto
    {
        private readonly IFilterAsyncRepository<TEntity, TFilterEntity> repository = repository;

        private readonly IEntityToDtoMapper<TEntity, TDto> mapper = mapper;

        private readonly IInputDtoToFilterEntityMapper<TFilterInputDto, TFilterEntity> mapperFilter = mapperFilter;

        public async Task<IList<TDto>> GetFilterListAsync(TFilterInputDto filter, CancellationToken cancellationToken)
        {
            var filterEntity = GenerateFilterEntity(filter);

            var entity = await repository.FindFilterAllAsync(filterEntity, cancellationToken);

            return mapper.ToMapList(entity);
        }

        private TFilterEntity GenerateFilterEntity(TFilterInputDto filter)
            => mapperFilter.ToMap(filter);
    }
}