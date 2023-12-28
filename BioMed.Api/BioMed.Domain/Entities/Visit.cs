using BioMed.Domain.Common;

namespace BioMed.Domain.Entities
{
    public class Visit : EntityBase
    {
        public DateTime VisitDate { get; set; }
        public string? Prescription { get; set; }
        public decimal TotalPrice { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public virtual ICollection<Treatment>? Treatments { get; set; }
        public virtual ICollection<Payment>? Payments { get; set; }
    }
}
