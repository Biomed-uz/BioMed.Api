using BioMed.Domain.Common;

namespace BioMed.Domain.Entities
{
    public class Patient : EntityBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? PhoneNumber {  get; set; }
        public string? Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Gender { get; set; }
        
        public virtual ICollection<Visit>? Visits { get; set; }
    }
}
