namespace BioMed.Domain.Entities
{
    public class DoctorDepartment : EntityBase
    {
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
