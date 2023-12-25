namespace BioMed.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; } 
        public string? Name { get; set; }

        public virtual ICollection<DoctorCategory>? DoctorCategories { get; set; }
    }
}
