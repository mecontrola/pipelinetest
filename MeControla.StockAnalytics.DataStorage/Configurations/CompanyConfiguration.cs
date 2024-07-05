using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Definition = MeControla.StockAnalytics.DataStorage.Schemas.CompanySchema;
using Fields = MeControla.StockAnalytics.DataStorage.Schemas.CompanySchema.Columns;

namespace MeControla.StockAnalytics.DataStorage.Configurations
{
#if DEBUG
    public
#else
    internal
#endif
    class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable(Definition.Table, Definition.Schema);

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.B3Code)
                   .IsUnique();

            builder.Property(p => p.Id).HasColumnName(Fields.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Uuid).HasColumnName(Fields.Uuid).IsRequired().HasMaxLength(36);
            builder.Property(p => p.Name).HasColumnName(Fields.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.B3Code).HasColumnName(Fields.B3Code).HasMaxLength(10).IsRequired();
            builder.Property(p => p.Document).HasColumnName(Fields.Document).IsRequired().HasMaxLength(18);
            builder.Property(p => p.Active).HasColumnName(Fields.Active).HasDefaultValue(true);
            builder.Property(p => p.CreatedAt).HasColumnName(Fields.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).HasColumnName(Fields.UpdatedAt);

            builder.HasMany(p => p.Tickers)
                   .WithOne(p => p.Company)
                   .HasForeignKey(p => p.CompanyId);
        }
    }
}