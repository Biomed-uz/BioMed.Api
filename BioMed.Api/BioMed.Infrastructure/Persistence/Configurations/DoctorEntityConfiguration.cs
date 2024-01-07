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
    public class DoctorEntityConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable(nameof(Doctor));

            builder.HasKey(d => d.Id);

            builder.Property(d => d.FullName)
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(d => d.PhoneNumber)
                .HasColumnType("Phone")
                .HasMaxLength(50);
            builder.Property(d => d.Email)
                .HasMaxLength(255);
            builder.Property(d => d.PricePerVisit)
                .HasColumnType("Money");

            builder.HasMany(d => d.DoctorDepartments)
                .WithOne(dd => dd.Doctor)
                .HasForeignKey(dd => dd.DoctorId);

            builder.HasMany(d => d.DoctorCategories)
                .WithOne(dc => dc.Doctor)
                .HasForeignKey(dc => dc.DoctorId);
        }
    }
}
