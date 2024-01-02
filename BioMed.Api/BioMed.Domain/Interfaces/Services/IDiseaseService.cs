using BioMed.Domain.DTOs.Disease;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IDiseaseService
    {
        PaginatedList<DiseaseDto> GetDiseases(DiseaseResourceParameters diseaseResourceParameters);
        DiseaseDto? GetDiseaseById(int id);
        DiseaseDto CreateDisease(DiseaseForCreateDto diseaseToCreate);
        void UpdateDisease(DiseaseForUpdateDto diseaseToUpdate);
        void DeleteDisease(int id);
    }
}
