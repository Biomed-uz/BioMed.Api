using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class DiseaseCategoryEntityConfiguration : IEntityTypeConfiguration<DiseaseCategory>
    {
        public void Configure(EntityTypeBuilder<DiseaseCategory> builder)
        {
            builder.ToTable(nameof(DiseaseCategory));

            builder.HasKey(dc => dc.Id);

            builder.Property(dc => dc.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasMany(dc => dc.Diseases)
                .WithOne(d => d.DiseaseCategory)
                .HasForeignKey(d => d.DiseaseCategoryId);
        }
    }
}
