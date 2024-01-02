using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class DiseaseRepository : RepositoryBase<Disease>, IDiseaseRepository
    {
        public DiseaseRepository(BioMedDbContext context) : base(context)
        {
        }
    }
}
