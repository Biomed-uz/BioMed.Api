namespace BioMed.Domain.DTOs.DoctorDepartment
{
    public record DoctorDepartmentForUpdateDto(
        int Id,
        int DoctorId,
        int DepartmentId);
}
