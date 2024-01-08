using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class VisitEntityConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.ToTable(nameof(Visit));

            builder.HasKey(v => v.Id);

            builder.Property(v => v.TotalPrice)
                .HasColumnType("Money");
            builder.Property(v => v.Prescription)
                .HasMaxLength(500);
            builder.Property(v => v.VisitDate)
                .HasColumnType(nameof(DateTime));

            builder.HasOne(v => v.Doctor)
                .WithMany(d => d.Visits)
                .HasForeignKey(v => v.DoctorId);
            builder.HasOne(v => v.Patient)
                .WithMany(p => p.Visits)
                .HasForeignKey(v => v.PatientId);
            builder.HasMany(v => v.Treatments)
                .WithOne(t => t.Visit)
                .HasForeignKey(t => t.VisitId);
            builder.HasMany(v => v.Payments)
                .WithOne(p => p.Visit)
                .HasForeignKey(p => p.VisitId);
        }
    }
}
