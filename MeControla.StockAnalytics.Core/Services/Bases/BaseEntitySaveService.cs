using FluentValidation;
using MeControla.Core.Data.Dtos;
using MeControla.Core.Data.Entities;
using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Core.Tools;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services.Bases
{
    public interface IBaseEntitySaveService<TInputDto>
          where TInputDto : class, IInputDto
    {
        Task<bool> SaveAsync(Guid? entityUuid, TInputDto input, CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    abstract class BaseEntitySaveService<TEntity, TInputDto>(IAsyncRepository<TEntity> repository, IValidator<TInputDto> validator)
        : IBaseEntitySaveService<TInputDto>
        where TEntity : class, IModificationDateTimeEntity, new()
        where TInputDto : class, IInputDto
    {
        protected abstract void FillEntity(TEntity entity, TInputDto input);

        protected abstract TEntity BuildEntity();

        protected virtual Task RunBeforeSave(TEntity entity, CancellationToken cancellationToken)
            => Task.CompletedTask;

        public async Task<bool> SaveAsync(Guid? entityUuid, TInputDto input, CancellationToken cancellationToken)
        {
            validator.ThrowIfInvalid<TEntity, TInputDto>(input);

            var entity = await LoadOrCreateEntityAsync(entityUuid, cancellationToken);

            FillEntity(entity, input);

            await SaveEntityAsync(entity, cancellationToken);

            await RunBeforeSave(entity, cancellationToken);

            return true;
        }

        private async Task<TEntity> LoadOrCreateEntityAsync(Guid? entityUuid, CancellationToken cancellationToken)
            => entityUuid.HasValue
             ? await repository.FindAsync(entityUuid.Value, cancellationToken)
             : BuildEntity();

        private async Task SaveEntityAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if (entity.Id == 0)
                await CreateEntityAsync(entity, cancellationToken);
            else
                await UpdateEntityAsync(entity, cancellationToken);
        }

        private async Task CreateEntityAsync(TEntity entity, CancellationToken cancellationToken)
            => await repository.CreateAsync(entity, cancellationToken);

        private async Task UpdateEntityAsync(TEntity entity, CancellationToken cancellationToken)
        {
            entity.UpdatedAt = DateTime.UtcNow;

            await repository.UpdateAsync(entity, cancellationToken);
        }
    }
}