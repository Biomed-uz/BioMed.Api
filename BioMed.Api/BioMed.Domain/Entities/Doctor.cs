namespace BioMed.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public decimal PricePerVisit { get; set; }

        public virtual ICollection<Visit>? Visits { get; set; }
        public virtual ICollection<DoctorDepartment>? DoctorDepartments { get; set; }
        public virtual ICollection<DoctorCategory>? DoctorCategories { get; set; }
    }
}
