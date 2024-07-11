using MeControla.Core.Data.Entities;
using MeControla.Core.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services.Bases
{
    public interface IBaseEntitySwitchAtiveInactiveService
    {
        Task<bool> SwitchStatusAsync(Guid productUuid, CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    abstract class BaseEntitySwitchAtiveInactiveService<TEntity>(IAsyncRepository<TEntity> repository) : IBaseEntitySwitchAtiveInactiveService
        where TEntity : class, IModificationDateTimeEntity
    {
        protected abstract void ChangeEntity(TEntity entity);

        public async Task<bool> SwitchStatusAsync(Guid entityUuid, CancellationToken cancellationToken)
        {
            var entity = await RetrieveEntityAsync(entityUuid, cancellationToken) ?? throw new Exception("Entity not found");

            ChangeEntity(entity);

            return await UpdateEntityAsync(entity, cancellationToken);
        }

        private async Task<TEntity> RetrieveEntityAsync(Guid entityUuid, CancellationToken cancellationToken)
            => await repository.FindAsync(entityUuid, cancellationToken);

        private async Task<bool> UpdateEntityAsync(TEntity entity, CancellationToken cancellationToken)
        {
            entity.UpdatedAt = DateTime.UtcNow;

            return await repository.UpdateAsync(entity, cancellationToken);
        }
    }
}