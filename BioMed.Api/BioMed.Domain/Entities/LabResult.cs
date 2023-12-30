namespace BioMed.Domain.Entities
{
    public class LabResult : EntityBase
    {
        public string? Result { get; set; }
        public DateTime? Date { get; set; }

        public int TestTypeId { get; set; }
        public TestType? TestType { get; set; }

        public virtual ICollection<Treatment>? Treatments { get; set;}
    }
}
