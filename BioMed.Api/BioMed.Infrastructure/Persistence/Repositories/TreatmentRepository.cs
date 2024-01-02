using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class TreatmentRepository : RepositoryBase<Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(BioMedDbContext context) : base(context)
        {
        }
    }
}
