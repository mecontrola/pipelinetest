using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Definition = MeControla.StockAnalytics.DataStorage.Schemas.TransactionSchema;
using Fields = MeControla.StockAnalytics.DataStorage.Schemas.TransactionSchema.Columns;

namespace MeControla.StockAnalytics.DataStorage.Configurations
{
#if DEBUG
    public
#else
    internal
#endif
    class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable(Definition.Table, Definition.Schema);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName(Fields.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Uuid).HasColumnName(Fields.Uuid).IsRequired().HasMaxLength(36);
            builder.Property(p => p.Date).HasColumnName(Fields.Date).IsRequired();
            builder.Property(p => p.Action).HasColumnName(Fields.Action).IsRequired();
            builder.Property(p => p.Amount).HasColumnName(Fields.Amount).IsRequired();
            builder.Property(p => p.Price).HasColumnName(Fields.Price).IsRequired();
            builder.Property(p => p.Total).HasColumnName(Fields.Total).IsRequired();
            builder.Property(p => p.CreatedAt).HasColumnName(Fields.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).HasColumnName(Fields.UpdatedAt);
            builder.Property(p => p.BrokerId).HasColumnName(Fields.BrokerId);
            builder.Property(p => p.TickerId).HasColumnName(Fields.TickerId);
            builder.Property(p => p.WalletId).HasColumnName(Fields.WalletId);

            builder.HasOne(p => p.Broker)
                   .WithMany()
                   .HasForeignKey(p => p.BrokerId);

            builder.HasOne(p => p.Ticker)
                   .WithMany()
                   .HasForeignKey(p => p.TickerId);

            builder.HasOne(p => p.Wallet)
                   .WithMany()
                   .HasForeignKey(p => p.WalletId);
        }
    }
}