using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class DoctorDepartmentRepository : RepositoryBase<DoctorDepartment>, IDoctorDepartmentRepository
    {
        public DoctorDepartmentRepository(BioMedDbContext context) : base(context)
        {
        }
    }
}
