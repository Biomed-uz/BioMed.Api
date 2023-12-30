using BioMed.Domain.DTOs.LabResult;

namespace BioMed.Domain.DTOs.TestType
{
    public record TestTypeDto(
        int Id,
        string Name,
        ICollection<LabResultDto> LabResults);
}
