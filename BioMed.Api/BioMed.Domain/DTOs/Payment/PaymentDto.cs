namespace BioMed.Domain.DTOs.Payment
{
    public record PaymentDto(
        int Id,
        decimal Amount,
        DateTime Date,
        int VisitId);
}
