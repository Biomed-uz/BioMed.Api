using BioMed.Domain.DTOs.DoctorDepartment;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IDoctorDepartmentService
    {
        PaginatedList<DoctorDepartmentDto> GetDoctorDepartments(DoctorDepartmentResourceParameters doctorDepartmentResourceParameters);
        DoctorDepartmentDto? GetDoctorDepartmentById(int id);
        DoctorDepartmentDto CreateDoctorDepartment(DoctorDepartmentForCreateDto doctorDepartmentToCreate);
        void UpdateDoctorDepartment(DoctorDepartmentForUpdateDto doctorDepartmentToUpdate);
        void DeleteDoctorDepartment(int id);
    }
}
