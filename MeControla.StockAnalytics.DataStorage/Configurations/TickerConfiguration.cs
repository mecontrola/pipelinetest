using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Definition = MeControla.StockAnalytics.DataStorage.Schemas.TickerSchema;
using Fields = MeControla.StockAnalytics.DataStorage.Schemas.TickerSchema.Columns;

namespace MeControla.StockAnalytics.DataStorage.Configurations
{
#if DEBUG
    public
#else
    internal
#endif
    class TickerConfiguration : IEntityTypeConfiguration<Ticker>
    {
        public void Configure(EntityTypeBuilder<Ticker> builder)
        {
            builder.ToTable(Definition.Table, Definition.Schema);

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.ISINCode)
                   .IsUnique();

            builder.Property(p => p.Id).HasColumnName(Fields.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Uuid).HasColumnName(Fields.Uuid).IsRequired().HasMaxLength(36);
            builder.Property(p => p.Name).HasColumnName(Fields.Name).IsRequired().HasMaxLength(10);
            builder.Property(p => p.ISINCode).HasColumnName(Fields.ISINCode);
            builder.Property(p => p.Active).HasColumnName(Fields.Active).HasDefaultValue(true);
            builder.Property(p => p.CreatedAt).HasColumnName(Fields.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).HasColumnName(Fields.UpdatedAt);
            builder.Property(p => p.CompanyId).HasColumnName(Fields.CompanyId);
        }
    }
}