namespace BioMed.Domain.Entities
{
    public class TestType : EntityBase
    {
        public string? Name { get; set; }

        public virtual ICollection<LabResult>? LabResults { get; set;}
    }
}
