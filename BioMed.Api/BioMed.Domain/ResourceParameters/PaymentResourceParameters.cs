namespace BioMed.Domain.ResourceParameters
{
    public class PaymentResourceParameters : ResourceParametersBase
    {
        public int VisitId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountLessThan { get; set; }
        public decimal AmountGreaterThan { get; set; }
        public override string OrderBy { get; set; } = "name";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
