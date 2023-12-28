using BioMed.Domain.Common;

namespace BioMed.Domain.Entities
{
    public class Disease : EntityBase
    {
        public int DiseaseCategoryId { get; set; }
        public DiseaseCategory? DiseaseCategory { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Treatment>? Treatments { get; set; }
    }
}
