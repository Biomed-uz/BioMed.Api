using BioMed.Domain.DTOs.Treatment;
using BioMed.Domain.Entities;

namespace BioMed.Domain.DTOs.Disease
{
    public record DiseaseDto(
        int Id,
        string Name,
        int DiseaseCategoryId,
        ICollection<TreatmentDto> Treatments);
}
