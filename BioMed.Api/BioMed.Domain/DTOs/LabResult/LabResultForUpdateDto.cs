namespace BioMed.Domain.DTOs.LabResult
{
    public record LabResultForUpdateDto(
        int Id,
        string Result,
        DateTime Date,
        int TestTypeId);
}
