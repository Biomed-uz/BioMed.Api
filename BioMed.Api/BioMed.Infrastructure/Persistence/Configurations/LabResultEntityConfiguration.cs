using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class LabResultEntityConfiguration : IEntityTypeConfiguration<LabResult>
    {
        public void Configure(EntityTypeBuilder<LabResult> builder)
        {
            builder.ToTable(nameof(LabResult));

            builder.HasKey(lr => lr.Id);

            builder.Property(lr => lr.Result)
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(lr => lr.Date)
                .HasColumnType(nameof(DateTime))
                .IsRequired();

            builder.HasOne(lr => lr.TestType)
                .WithMany(t => t.LabResults)
                .HasForeignKey(lr => lr.TestTypeId);
        }
    }
}
