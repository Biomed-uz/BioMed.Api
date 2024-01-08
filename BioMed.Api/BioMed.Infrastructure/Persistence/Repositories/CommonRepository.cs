using BioMed.Domain.Interfaces.Repositories;

namespace BioMed.Infrastructure.Persistence.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        private readonly BioMedDbContext _dbContext;

        private ICategoryRepository _category;
        public ICategoryRepository Category
        {
            get
            {
                _category ??= new CategoryRepository(_dbContext);

                return _category;
            }
        }

        private IDepartmentRepository _department;
        public IDepartmentRepository Department
        {
            get
            {
                _department ??= new DepartmentRepository(_dbContext);

                return _department;
            }
        }

        private IDoctorRepository _doctor;
        public IDoctorRepository Doctor
        {
            get
            {
                _doctor ??= new DoctorRepository(_dbContext);

                return _doctor;
            }
        }

        private IDoctorCategoryRepository _doctorCategory;
        public IDoctorCategoryRepository DoctorCategory
        {
            get
            {
                _doctorCategory ??= new DoctorCategoryRepository(_dbContext);

                return _doctorCategory;
            }
        }

        private IDoctorDepartmentRepository _doctorDepartment;
        public IDoctorDepartmentRepository DoctorDepartment
        {
            get
            {
                _doctorDepartment ??= new DoctorDepartmentRepository(_dbContext);

                return _doctorDepartment;
            }
        }

        private IPatientRepository _petient;
        public IPatientRepository Patient
        {
            get
            {
                _petient ??= new PatientRepository(_dbContext);

                return _petient;
            }
        }

        private IVisitRepostory _visit;
        public IVisitRepostory Visit
        {
            get
            {
                _visit ??= new VisitRepository(_dbContext);

                return _visit;
            }
        }

        private IPaymentRepository _payment;
        public IPaymentRepository Payment
        {
            get
            {
                _payment ??= new PaymentRepository(_dbContext);

                return _payment;
            }
        }

        private ITestTypeRepository _testType;
        public ITestTypeRepository TestType
        {
            get
            {
                _testType ??= new TestTypeRepository(_dbContext);

                return _testType;
            }
        }

        private ILabResultRepository _labResult;
        public ILabResultRepository LabResult
        {
            get
            {
                _labResult ??= new LabResultRepository(_dbContext);

                return _labResult;
            }
        }

        private IDiseaseCategoryRepository _diseaseCategory;
        public IDiseaseCategoryRepository DiseaseCategory
        {
            get
            {
                _diseaseCategory ??= new DiseaseCategoryRepository(_dbContext);

                return _diseaseCategory;
            }
        }

        private IDiseaseRepository _disease;
        public IDiseaseRepository Disease
        {
            get
            {
                _disease ??= new DiseaseRepository(_dbContext);

                return _disease;
            }
        }

        private ITreatmentRepository _treatment;
        public ITreatmentRepository Treatment
        {
            get
            {
                _treatment ??= new TreatmentRepository(_dbContext);
                
                return _treatment;
            }
        }

        public CommonRepository(BioMedDbContext dbContext)
        {
            _dbContext = dbContext;

            _category = new CategoryRepository(_dbContext);
            _department = new DepartmentRepository(_dbContext);
            _doctor = new DoctorRepository(_dbContext);
            _doctorCategory = new DoctorCategoryRepository(_dbContext);
            _doctorDepartment = new DoctorDepartmentRepository(_dbContext);
            _petient = new PatientRepository(_dbContext);
            _visit = new VisitRepository(_dbContext);
            _payment = new PaymentRepository(_dbContext);
            _testType = new TestTypeRepository(_dbContext);
            _labResult = new LabResultRepository(_dbContext);
            _diseaseCategory = new DiseaseCategoryRepository(_dbContext);
            _disease = new DiseaseRepository(_dbContext);
            _treatment = new TreatmentRepository(_dbContext);
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
