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
    public class DoctorDepartmentEntityConfiguration : IEntityTypeConfiguration<DoctorDepartment>
    {
        public void Configure(EntityTypeBuilder<DoctorDepartment> builder)
        {
            builder.ToTable(nameof(DoctorDepartment));

            builder.HasOne(dd => dd.Department)
                .WithMany(d => d.DoctorDepartments)
                .HasForeignKey(dd => dd.DepartmentId);

            builder.HasOne(dd => dd.Doctor)
                .WithMany(d => d.DoctorDepartments)
                .HasForeignKey(dd => dd.DoctorId);
        }
    }
}
