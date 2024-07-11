using MeControla.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MeControla.StockAnalytics.DataStorage
{
    [RequiresUnreferencedCode("Use 'MethodFriendlyToTrimming' instead")]
    public class DbAppContextFactory : BaseDbContextFactory<DbAppContext>
    {
        private const string CONNECTION_STRING = "Data Source=storage.db";

        protected override void Configure(DbContextOptionsBuilder<DbAppContext> options)
            => options.UseSqlite(CONNECTION_STRING);
    }
}