namespace BioMed.Domain.DTOs.LabResult
{
    public record LabResultForCreateDto(
        string Result,
        DateTime Date,
        int TestTypeId);
}
