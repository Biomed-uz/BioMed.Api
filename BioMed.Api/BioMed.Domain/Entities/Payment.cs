namespace BioMed.Domain.Entities
{
    public class Payment : EntityBase
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public int VisitId { get; set; }
        public Visit? Visit { get; set; }
    }
}
