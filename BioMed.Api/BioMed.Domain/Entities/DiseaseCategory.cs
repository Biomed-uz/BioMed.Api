namespace BioMed.Domain.Entities
{
    public class DiseaseCategory : EntityBase
    {
        public string? Name { get; set; }

        public virtual ICollection<Disease>? Diseases { get; set; }
    }
}
