using BioMed.Domain.DTOs.Treatment;

namespace BioMed.Domain.DTOs.LabResult
{
    public record LabResultDto(
        int Id,
        string Result,
        DateTime Date,
        int TestTypeId,
        ICollection<TreatmentDto> Treatments);
}
