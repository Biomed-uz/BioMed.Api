namespace BioMed.Domain.ResourceParameters
{
    public class DepartmentResourceParameters : ResourceParametersBase
    {
        public override string OrderBy { get; set; } = "name";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
