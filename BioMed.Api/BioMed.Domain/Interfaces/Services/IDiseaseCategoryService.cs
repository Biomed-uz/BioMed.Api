using BioMed.Domain.DTOs.DiseaseCategory;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IDiseaseCategoryService
    {
        PaginatedList<DiseaseCategoryDto> GetCategories(DiseaseCategoryResourceParameters diseaseCategoryResourceParameters);
        DiseaseCategoryDto? GetDiseaseCategoryById(int id);
        DiseaseCategoryDto CreateDiseaseCategory(DiseaseCategoryForCreateDto diseaseCategoryToCreate);
        void UpdateDiseaseCategory(DiseaseCategoryForUpdateDto diseaseCategoryToUpdate);
        void DeleteDiseaseCategory(int id);
    }
}
