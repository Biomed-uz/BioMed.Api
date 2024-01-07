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
    public class TestTypeEntityConfiguration : IEntityTypeConfiguration<TestType>
    {
        public void Configure(EntityTypeBuilder<TestType> builder)
        {
            builder.ToTable(nameof(TestType));

            builder.Property(t => t.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasMany(t => t.LabResults)
                .WithOne(l => l.TestType)
                .HasForeignKey(l => l.TestTypeId);
        }
    }
}
