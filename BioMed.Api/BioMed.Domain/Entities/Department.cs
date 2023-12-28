using BioMed.Domain.Common;

namespace BioMed.Domain.Entities
{
    public class Department : EntityBase
    {
        public string? Name { get; set; }

        public virtual ICollection<DoctorDepartment>? DoctorDepartments { get; set; }
    }
}
