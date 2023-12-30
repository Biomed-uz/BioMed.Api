namespace BioMed.Domain.DTOs.Payment
{
    public record PaymentForUpdateDto(
        int Id,
        decimal Amount,
        DateTime Date,
        int VisitId);
}
