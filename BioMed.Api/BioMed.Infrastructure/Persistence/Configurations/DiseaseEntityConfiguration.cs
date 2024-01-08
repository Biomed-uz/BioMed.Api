using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class DiseaseEntityConfiguration : IEntityTypeConfiguration<Disease>
    {
        public void Configure(EntityTypeBuilder<Disease> builder)
        {
            builder.ToTable(nameof(Disease));

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasOne(d => d.DiseaseCategory)
                .WithMany(dc => dc.Diseases)
                .HasForeignKey(d => d.DiseaseCategoryId);
            builder.HasMany(d => d.Treatments)
                .WithOne(t => t.Disease)
                .HasForeignKey(t => t.DiseaseId);
                
        }
    }
}
