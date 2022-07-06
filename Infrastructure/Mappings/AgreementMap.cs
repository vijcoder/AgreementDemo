using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Mappings
{
    [ExcludeFromCodeCoverage]
    public class AgreementMap : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.ProductGroupId).IsRequired();
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.EffectiveDate).IsRequired();

            builder.Property(t => t.ExpirationDate).IsRequired();
            builder.Property(t => t.ProductPrice).IsRequired();
            builder.Property(t => t.NewPrice).IsRequired();
            builder.Property(t => t.IsActive);
            builder.Property(t => t.WhenEntered);

            builder.Property(t => t.ModifiedBy);
            builder.Property(t => t.WhenModified);
        }
    }
}
