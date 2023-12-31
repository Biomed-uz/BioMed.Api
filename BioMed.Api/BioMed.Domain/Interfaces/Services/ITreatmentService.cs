using BioMed.Domain.DTOs.Treatment;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface ITreatmentService
    {
        PaginatedList<TreatmentDto> GetTreatments(TreatmentResourceParameters treatmentResourceParameters);
        TreatmentDto? GetTreatmentById(int id);
        TreatmentDto CreateTreatment(TreatmentForCreateDto treatmentToCreate);
        void UpdateTreatment(TreatmentForUpdateDto treatmentToUpdate);
        void DeleteTreatment(int id);
    }
}
}
