using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class PatientEntityConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable(nameof(Patient));

            builder.HasKey(c => c.Id);

            builder.Property(p => p.FirstName)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(p => p.LastName)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(p => p.MiddleName)
                .HasMaxLength(255);
            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(50);
            builder.Property(p => p.Email)
                .HasMaxLength(255);

            builder.HasMany(p => p.Visits)
                .WithOne(v => v.Patient)
                .HasForeignKey(v => v.PatientId);
        }
    }
}
