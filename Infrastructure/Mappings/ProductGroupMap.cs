using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Mappings
{
    [ExcludeFromCodeCoverage]
    public class ProductGroupMap : IEntityTypeConfiguration<ProductGroup>
    {
        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.GroupDescription).IsRequired();
            builder.Property(t => t.GroupCode).IsRequired();

            builder.Property(t => t.IsActive);
            builder.Property(t => t.WhenEntered);

            builder.Property(t => t.ModifiedBy);
            builder.Property(t => t.WhenModified);
        }
    }
}
