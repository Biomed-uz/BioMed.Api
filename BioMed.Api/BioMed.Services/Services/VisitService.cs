using AutoMapper;
using BioMed.Domain.DTOs.Visit;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class VisitService : IVisitService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public VisitService(IMapper mapper,
            BioMedDbContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public PaginatedList<VisitDto> GetVisits(
            VisitResourceParameters visitResourceParameters)
        {
            var query = _context.Visits.AsQueryable();

            if(!string.IsNullOrWhiteSpace(visitResourceParameters.OrderBy))
            {
                query = visitResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "totalPrice" => query.OrderBy(x => x.TotalPrice),
                    "totalPriceDesc" => query.OrderByDescending(x => x.TotalPrice),
                    "visitDate" => query.OrderBy(x => x.VisitDate),
                    "visitDateDesc" => query.OrderByDescending(x => x.VisitDate),
                    "doctorId" => query.OrderBy(x => x.DoctorId),
                    "doctorIdDesc" => query.OrderByDescending(x => x.DoctorId),
                    "patientId" => query.OrderBy(x => x.PatientId),
                    "patientIdDesc" => query.OrderByDescending(x => x.PatientId),
                    _ => query.OrderBy(x => x.VisitDate)
                };
            }

            var visits = query.ToPaginatedList(visitResourceParameters.PageSize,
                visitResourceParameters.PageNumber);
            var visitDtos = _mapper.Map<List<VisitDto>>(visits);

            return new PaginatedList<VisitDto>(visitDtos,
                visits.TotalPages,
                visits.CurrentPage,
                visits.PageSize);
        }

        public VisitDto? GetVisitById(int id)
        {
            var visit = _context.Visits.FirstOrDefault(x => x.Id == id);

            return _mapper.Map<VisitDto>(visit);
        }

        public VisitDto CreateVisit(VisitForCreateDto visitToCreate)
        {
            var visitEntity = _mapper.Map<Visit>(visitToCreate);

            _context.Visits.Add(visitEntity);
            _context.SaveChanges();

            return _mapper.Map<VisitDto>(visitEntity);
        }

        public void UpdateVisit(VisitForUpdateDto visitToUpdate)
        {
            var visitEntity = _mapper.Map<Visit>(visitToUpdate);

            _context.Visits.Update(visitEntity);
            _context.SaveChanges();
        }

        public void DeleteVisit(int id)
        {
            var visit = _context.Visits.FirstOrDefault(_x => _x.Id == id);

            if(visit is not null)
            {
                _context.Visits.Remove(visit);
                _context.SaveChanges();
            }
        }
    }
}
