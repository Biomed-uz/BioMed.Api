namespace BioMed.Domain.Entities
{
    public class DoctorCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
