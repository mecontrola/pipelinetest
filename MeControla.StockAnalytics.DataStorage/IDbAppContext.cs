using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeControla.StockAnalytics.DataStorage
{
    public interface IDbAppContext : IDbContext
    {
        DbSet<Broker> Brokers { get; }
        DbSet<Company> Companies { get; }
        DbSet<Consolidated> Consolidated { get; }
        DbSet<Register> Registers { get; }
        DbSet<Ticker> Tickers { get; }
        DbSet<Transaction> Transactions { get; }
        DbSet<Wallet> Wallets { get; }
    }
}