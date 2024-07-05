using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Definition = MeControla.StockAnalytics.DataStorage.Schemas.BrokerSchema;
using Fields = MeControla.StockAnalytics.DataStorage.Schemas.BrokerSchema.Columns;

namespace MeControla.StockAnalytics.DataStorage.Configurations
{
#if DEBUG
    public
#else
    internal
#endif
    class BrokerConfiguration : IEntityTypeConfiguration<Broker>
    {
        public void Configure(EntityTypeBuilder<Broker> builder)
        {
            builder.ToTable(Definition.Table, Definition.Schema);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName(Fields.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Uuid).HasColumnName(Fields.Uuid).IsRequired().HasMaxLength(36);
            builder.Property(p => p.Name).HasColumnName(Fields.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Active).HasColumnName(Fields.Active).HasDefaultValue(true);
            builder.Property(p => p.CreatedAt).HasColumnName(Fields.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).HasColumnName(Fields.UpdatedAt);
        }
    }
}