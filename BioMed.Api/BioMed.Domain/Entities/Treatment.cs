using BioMed.Domain.Common;

namespace BioMed.Domain.Entities
{
    public class Treatment : EntityBase
    {
        public string? Prescription { get; set; }

        public int VisitId { get; set; }
        public Visit? Visit { get; set; }
        public int LabResultId { get; set; }
        public LabResult? LabResult { get; set; }
        public int DiseaseId { get; set; }
        public Disease? Disease { get; set; }
    }
}
