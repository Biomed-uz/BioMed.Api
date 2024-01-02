using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class DiseaseCategoryRepository : RepositoryBase<DiseaseCategory>, IDiseaseCategoryRepository
    {
        public DiseaseCategoryRepository(BioMedDbContext context) : base(context)
        { 
        }
    }
}
