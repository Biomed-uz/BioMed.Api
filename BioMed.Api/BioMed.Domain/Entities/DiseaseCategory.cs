namespace BioMed.Domain.Entities
{
    public class DiseaseCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Disease>? Diseases { get; set; }
    }
}
