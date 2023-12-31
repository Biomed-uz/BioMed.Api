namespace BioMed.Domain.ResourceParameters
{
    public class LabResultResourceParameters : ResourceParametersBase
    {
        public int TestTypeId { get; set; }
        public override string OrderBy { get; set; } = "name";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
