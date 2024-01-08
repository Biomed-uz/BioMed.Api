using BioMed.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class TreatmentEntityConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.ToTable(nameof(Treatment));

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Prescription)
                .HasMaxLength(500);

            builder.HasOne(t => t.Visit)
                .WithMany(v => v.Treatments)
                .HasForeignKey(t => t.VisitId);
            builder.HasOne(t => t.Disease)
                .WithMany(d => d.Treatments)
                .HasForeignKey(t => t.DiseaseId);
            builder.HasOne(t => t.LabResult)
                .WithMany(l => l.Treatments)
                .HasForeignKey(t => t.LabResultId);
        }
    }
}
