namespace BioMed.Domain.Entities
{
    public class Disease
    {
        public int Id { get; set; }
        public int DiseaseCategoryId { get; set; }
        public DiseaseCategory? DiseaseCategory { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Treatment>? Treatments { get; set; }
    }
}
