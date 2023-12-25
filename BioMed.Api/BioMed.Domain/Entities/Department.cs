namespace BioMed.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<DoctorDepartment>? DoctorDepartments { get; set; }
    }
}
