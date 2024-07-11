using MeControla.StockAnalytics.Data.Entities;

namespace MeControla.StockAnalytics.DataStorage.Schemas
{
#if DEBUG
    public
#else
    internal
#endif
    class TransactionSchema : BaseSchema<Transaction>
    {
        public static class Columns
        {
            public static string Id { get; } = Metadata.GetColumnName(x => x.Id);
            public static string Uuid { get; } = Metadata.GetColumnName(x => x.Uuid);
            public static string Date { get; } = Metadata.GetColumnName(x => x.Date);
            public static string Action { get; } = Metadata.GetColumnName(x => x.Action);
            public static string Amount { get; } = Metadata.GetColumnName(x => x.Amount);
            public static string Price { get; } = Metadata.GetColumnName(x => x.Price);
            public static string Total { get; } = Metadata.GetColumnName(x => x.Total);
            public static string CreatedAt { get; } = Metadata.GetColumnName(x => x.CreatedAt);
            public static string UpdatedAt { get; } = Metadata.GetColumnName(x => x.UpdatedAt);
            public static string BrokerId { get; } = BrokerSchema.Columns.Id;
            public static string TickerId { get; } = TickerSchema.Columns.Id;
            public static string WalletId { get; } = WalletSchema.Columns.Id;
        }
    }
}