using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class PaymentEntityConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Amount)
                .HasColumnType("Money");
            builder.Property(p => p.Date)
                .HasColumnType(nameof(DateTime))
                .IsRequired();

            builder.HasOne(p => p.Visit)
                .WithMany(v => v.Payments)
                .HasForeignKey(p => p.VisitId);
        }
    }
}
