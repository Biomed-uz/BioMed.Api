namespace BioMed.Domain.DTOs.DoctorDepartment
{
    public record DoctorDepartmentDto(
        int Id,
        int DoctorId,
        int DepartmentId);
}
