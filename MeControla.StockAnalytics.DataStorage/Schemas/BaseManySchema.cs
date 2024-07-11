using MeControla.Core.Data.Entities;
using MeControla.Core.Tools;

namespace MeControla.StockAnalytics.DataStorage.Schemas
{
#if DEBUG
    public
#else
    internal
#endif
    abstract class BaseManySchema<T, TRoot, TTarget>
        where T : class, IManyEntity<TRoot, TTarget>
        where TRoot : IEntity
        where TTarget : IEntity
    {
        protected const string SCHEMA_NAME = "stocks";

        protected static TableMetadata<T> Metadata { get; } = new(SCHEMA_NAME);

        public static string Table { get; } = Metadata.GetTableName();
        public static string Schema { get; } = Metadata.GetSchemaName();
    }
}