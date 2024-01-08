using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioMed.Infrastructure.Persistence.Configurations
{
    public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable(nameof(Department));

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasMany(d => d.DoctorDepartments)
                .WithOne(dd => dd.Department)
                .HasForeignKey(dd => dd.DepartmentId);
        }
    }
}
