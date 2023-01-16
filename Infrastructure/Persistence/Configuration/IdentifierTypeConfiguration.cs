using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class IdentifierTypeConfiguration : IEntityTypeConfiguration<IdentifierType>
    {
        public void Configure(EntityTypeBuilder<IdentifierType> builder)
        {

            //properties
            builder.Property(e => e.NameArabic).HasMaxLength(50);
            builder.Property(e => e.NameEnglish).HasMaxLength(50);
            // keys and index 
            builder.HasKey(e => e.IdentifierTypeId);
            //relations
        }
    }
}
