namespace TransactionService.Dtos
{
    public class TransactionCreateRequest
    {
        public Guid AccountId { get; set; }
        public Guid? TargetAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } // CREDIT | DEBIT | TRANSFER
        public string? Description { get; set; }
    }
}
