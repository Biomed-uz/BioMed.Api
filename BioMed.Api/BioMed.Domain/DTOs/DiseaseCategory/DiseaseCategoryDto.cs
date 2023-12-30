using BioMed.Domain.DTOs.Disease;

namespace BioMed.Domain.DTOs.DiseaseCategory
{
    public record DiseaseCategoryDto(
        int Id,
        string Name,
        ICollection<DiseaseDto> Diseases);
}
