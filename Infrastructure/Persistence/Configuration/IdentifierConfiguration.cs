using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class IdentifierConfiguration : IEntityTypeConfiguration<Identifier>
    {
        public void Configure(EntityTypeBuilder<Identifier> builder)
        {
            //properties
            builder.Property(e => e.IdentifierNumber).HasMaxLength(10);
            // keys and index 
            builder.HasKey(e => e.IdentifierId);

            //relations

            builder.HasOne(e => e.IdentifierType).WithOne(e => e.Identifier)
                .HasForeignKey<Identifier>(e => e.IdentifierTypeId);
            

        }
    }
}
