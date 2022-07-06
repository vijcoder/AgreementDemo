using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Mappings
{
    [ExcludeFromCodeCoverage]
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ProductGroupId).IsRequired();
            builder.Property(t => t.ProductDescription).IsRequired();
            builder.Property(t => t.ProductNumber).IsRequired();
            builder.Property(t => t.Price).IsRequired();

            builder.Property(t => t.IsActive);
            builder.Property(t => t.WhenEntered);

            builder.Property(t => t.ModifiedBy);
            builder.Property(t => t.WhenModified);
        }
    }
}
