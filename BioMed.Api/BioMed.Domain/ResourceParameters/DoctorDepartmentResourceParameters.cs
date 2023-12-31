namespace BioMed.Domain.ResourceParameters
{
    public class DoctorDepartmentResourceParameters : ResourceParametersBase
    {
        public int DoctorId { get; set; }
        public int DepartmentId { get; set; }
        public override string OrderBy { get; set; } = "name";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
