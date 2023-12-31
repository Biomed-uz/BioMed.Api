using BioMed.Domain.DTOs.Visit;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IVisitService
    {
        PaginatedList<VisitDto> GetVisits(VisitResourceParameters visitResourceParameters);
        VisitDto? GetVisitById(int id);
        VisitDto CreateVisit(VisitForCreateDto visitToCreate);
        void UpdateVisit(VisitForUpdateDto visitToUpdate);
        void DeleteVisit(int id);
    }
}
