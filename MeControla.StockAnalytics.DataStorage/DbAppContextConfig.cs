using MeControla.StockAnalytics.DataStorage.DataSeeding;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MeControla.StockAnalytics.DataStorage
{
    [RequiresUnreferencedCode("Use 'MethodFriendlyToTrimming' instead")]
    public sealed partial class DbAppContext : DbContext
    {
        public DbAppContext(DbContextOptions<DbAppContext> options)
            : base(options)
        {
            if (Database.IsRelational())
                Database.Migrate();
            else
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => base.OnConfiguring(optionsBuilder);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbAppContext).Assembly);

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}