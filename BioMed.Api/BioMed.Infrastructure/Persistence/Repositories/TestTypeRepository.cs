using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class TestTypeRepository : RepositoryBase<TestType>, ITestTypeRepository
    {
        public TestTypeRepository(BioMedDbContext context) : base(context) 
        {
        }
    }
}
