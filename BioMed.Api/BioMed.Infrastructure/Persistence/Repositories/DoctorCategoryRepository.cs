using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class DoctorCategoryRepository : RepositoryBase<DoctorCategory>, IDoctorCategoryRepository
    {
        public DoctorCategoryRepository(BioMedDbContext context) : base(context) 
        {
        }
    }
}
