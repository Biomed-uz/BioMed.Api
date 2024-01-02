using BioMed.Domain.DTOs.DoctorCategory;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IDoctorCategoryService
    {
        PaginatedList<DoctorCategoryDto> GetDoctorCategories(DoctorCategoryResourceParameters doctorCategoryResourceParameters);
        DoctorCategoryDto? GetDoctorCategoryById(int id);
        DoctorCategoryDto CreateDoctorCategory(DoctorCategoryForCreateDto doctorCategoryToCreate);
        void UpdateDoctorCategory(DoctorCategoryForUpdateDto doctorCategoryToUpdate);
        void DeleteDoctorCategory(int id);
    }
}
