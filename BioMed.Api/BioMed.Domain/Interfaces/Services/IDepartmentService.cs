using BioMed.Domain.DTOs.Department;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IDepartmentService
    {
        PaginatedList<DepartmentDto> GetDepartments(DepartmentResourceParameters departmentResourceParameters);
        DepartmentDto? GetDepartmentById(int id);
        DepartmentDto CreateDepartment(DepartmentForCreateDto departmentToCreate);
        void UpdateDepartment(DepartmentForUpdateDto departmentToUpdate);
        void DeleteDepartment(int id);
    }
}
