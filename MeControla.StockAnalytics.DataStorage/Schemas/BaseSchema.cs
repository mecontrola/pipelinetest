using MeControla.Core.Data.Entities;
using MeControla.Core.Tools;

namespace MeControla.StockAnalytics.DataStorage.Schemas
{
#if DEBUG
    public
#else
    internal
#endif
    abstract class BaseSchema<T>
        where T : class, IEntity
    {
        protected const string SCHEMA_NAME = "stocks";

        protected static TableMetadata<T> Metadata { get; } = new(SCHEMA_NAME);

        public static string Table { get; } = Metadata.GetTableName();
        public static string Schema { get; } = Metadata.GetSchemaName();
    }
}