using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class DoctorCategoryEntityConfiguration : IEntityTypeConfiguration<DoctorCategory>
    {
        public void Configure(EntityTypeBuilder<DoctorCategory> builder)
        {
            builder.ToTable(nameof(DoctorCategory));

            builder.HasOne(dc => dc.Category)
                .WithMany(c => c.DoctorCategories)
                .HasForeignKey(dc => dc.CategoryId);

            builder.HasOne(dc => dc.Doctor)
                .WithMany(d => d.DoctorCategories)
                .HasForeignKey(dc => dc.DoctorId);
        }
    }
}
