namespace BioMed.Domain.Entities
{
    public class Category : EntityBase
    {
        public string? Name { get; set; }

        public virtual ICollection<DoctorCategory>? DoctorCategories { get; set; }
    }
}
