namespace BioMed.Domain.Entities
{
    public class TestType
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<LabResult>? LabResults { get; set;}
    }
}
