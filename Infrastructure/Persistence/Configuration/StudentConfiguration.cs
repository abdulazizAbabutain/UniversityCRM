using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //properties  
            builder.Property(e => e.FirstNameArabic).HasMaxLength(50);
            builder.Property(e => e.SecondNameArabic).HasMaxLength(50);
            builder.Property(e => e.ThirdNameArabic).HasMaxLength(50);
            builder.Property(e => e.FamilyNameArabic).HasMaxLength(50);
            builder.Property(e => e.FirstNameEnglish).HasMaxLength(50);
            builder.Property(e => e.SecondNameEnglish).HasMaxLength(50);
            builder.Property(e => e.ThirdNameEnglish).HasMaxLength(50);
            builder.Property(e => e.FamilyNameEnglish).HasMaxLength(50);
            builder.Property(e => e.PhoneCountyCode).HasMaxLength(5);
            builder.Property(e => e.PhoneNumber).HasMaxLength(10);
            
            // keys and index 
            builder.HasKey(e => e.StudentId);
            // relation
            builder.HasOne(e => e.Identifier)
                .WithOne(e => e.Student)
                .HasForeignKey<Student>(e => e.StudentId);

        }
    }
}
