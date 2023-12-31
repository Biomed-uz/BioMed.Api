namespace BioMed.Domain.ResourceParameters
{
    public class VisitResourceParameters : ResourceParametersBase
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalPriceLessThan { get; set; }
        public decimal TotalPriceGreaterThan { get; set; }
        public override string OrderBy { get; set; } = "prescription";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
