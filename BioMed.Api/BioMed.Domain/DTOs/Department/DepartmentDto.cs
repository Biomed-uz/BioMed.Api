using BioMed.Domain.DTOs.DoctorDepartment;

namespace BioMed.Domain.DTOs.Department
{
    public record DepartmentDto(
        int Id,
        string Name,
        ICollection<DoctorDepartmentDto> DoctorDepartments);
}
