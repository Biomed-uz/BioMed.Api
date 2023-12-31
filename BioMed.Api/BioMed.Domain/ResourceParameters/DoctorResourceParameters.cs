namespace BioMed.Domain.ResourceParameters
{
    public class DoctorResourceParameters : ResourceParametersBase
    {
        public decimal? PricePerVisit { get; set; }
        public decimal? PricePerVisitLessThan { get; set; }
        public decimal? PricePerVisitDreaterThan { get; set; }
        public override string OrderBy { get; set; } = "fullname";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
