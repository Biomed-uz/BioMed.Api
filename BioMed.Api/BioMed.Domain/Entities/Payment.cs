namespace BioMed.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public int VisitId { get; set; }
        public Visit? Visit { get; set; }
    }
}
