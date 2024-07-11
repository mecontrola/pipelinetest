using MeControla.StockAnalytics.Data.Entities;

namespace MeControla.StockAnalytics.DataStorage.Schemas
{
#if DEBUG
    public
#else
    internal
#endif
    class CompanySchema : BaseSchema<Company>
    {
        public static class Columns
        {
            public static string Id { get; } = Metadata.GetColumnName(x => x.Id);
            public static string Uuid { get; } = Metadata.GetColumnName(x => x.Uuid);
            public static string Name { get; } = Metadata.GetColumnName(x => x.Name);
            public static string B3Code { get; } = Metadata.GetColumnName(x => x.B3Code);
            public static string Document { get; } = Metadata.GetColumnName(x => x.Document);
            public static string Active { get; } = Metadata.GetColumnName(x => x.Active);
            public static string CreatedAt { get; } = Metadata.GetColumnName(x => x.CreatedAt);
            public static string UpdatedAt { get; } = Metadata.GetColumnName(x => x.UpdatedAt);
        }
    }
}