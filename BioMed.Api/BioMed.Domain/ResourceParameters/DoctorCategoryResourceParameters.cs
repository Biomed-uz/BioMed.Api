namespace BioMed.Domain.ResourceParameters
{
    public class DoctorCategoryResourceParameters : ResourceParametersBase
    {
        public int CategoryId { get; set; }
        public int DoctorId { get; set; }
        public override string OrderBy { get; set; } = "name";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
