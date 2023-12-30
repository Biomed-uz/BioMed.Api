using BioMed.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BioMed.Infrastructure.Persistence
{
    public class BioMedDbContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DiseaseCategory> DiseaseCategories { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorCategory> DoctorCategories { get; set; }
        public virtual DbSet<DoctorDepartment> DoctorDepartments { get; set; }
        public virtual DbSet<LabResult> LabResults { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<TestType> TestTypes { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }

        public BioMedDbContext(DbContextOptions<BioMedDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
