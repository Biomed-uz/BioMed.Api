using BioMed.Domain.DTOs.LabResult;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface ILabResultService
    {
        PaginatedList<LabResultDto> GetLabResults(LabResultResourceParameters labResultResourceParameters);
        LabResultDto? GetLabResultById(int id);
        LabResultDto CreateLabResult(LabResultForCreateDto labResultToCreate);
        void UpdateLabResult(LabResultForUpdateDto labResultToUpdate);
        void DeleteLabResult(int id);
    }
}
