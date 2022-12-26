using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenFood.Domain.Models;

namespace OpenFood.Infra.Data.Context.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasColumnType("BIGINT").IsRequired();
            builder.Property(x => x.Status).HasConversion<byte>().HasDefaultValue(0);
            builder.Property(x => x.ImportedT).HasColumnType("DATETIME");
            builder.Property(x => x.Url).HasConversion<string>();
            builder.Property(x => x.ProductName).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.Quantity).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.Categories).HasColumnType("VARCHAR(512)");
            builder.Property(x => x.Packaging).HasColumnType("VARCHAR(512)");
            builder.Property(x => x.Brands).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.ImageUrl).HasConversion<string>();
        }
    }
}
