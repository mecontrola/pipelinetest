using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeControla.StockAnalytics.DataStorage
{
    public sealed partial class DbAppContext : IDbAppContext
    {
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Consolidated> Consolidated { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Ticker> Tickers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}