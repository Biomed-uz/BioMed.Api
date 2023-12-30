namespace BioMed.Domain.DTOs.Disease
{
    public record DiseaseForUpdateDto(
        int Id,
        string Name,
        int DiseaseCategory);
}
