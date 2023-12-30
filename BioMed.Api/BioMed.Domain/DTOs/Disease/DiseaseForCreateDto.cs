namespace BioMed.Domain.DTOs.Disease
{
    public record DiseaseForCreateDto(
        string Name,
        int DiseaseCategoryId);
}
