namespace BioMed.Domain.ResourceParameters
{
    public class TreatmentResourceParameters : ResourceParametersBase
    {
        public int VisitId { get; set; }
        public int LabResultId { get; set; }
        public int DiseaseId { get; set; }
        public override string OrderBy { get; set; } = "prescription";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
