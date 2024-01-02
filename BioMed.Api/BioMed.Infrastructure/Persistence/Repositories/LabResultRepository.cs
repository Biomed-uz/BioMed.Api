using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class LabResultRepository : RepositoryBase<LabResult>, ILabResultRepository
    {
        public LabResultRepository(BioMedDbContext context) : base(context)
        {
        }
    }
}
